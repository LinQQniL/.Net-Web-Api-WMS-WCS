using System;
using WMS.WebApi.Models;

public class Muse
{
	public Muse()
	{

        public async Task<ResultUserMenuDto> ShowUserMenuAsync(string? userId)
    {
        //定义：查询结果定义
        ResultUserMenuDto resultUserMenuDto = new ResultUserMenuDto();
        //取值：获取用户信息
        UserInfo userInfo = await Context.Queryable<UserInfo>().FirstAsync(l => l.UserId == userId);
        if (userInfo.IsEmpty())
            throw new Exception("获取用户菜单失败，用户菜单不存在");
        //赋值：将用户信息赋给结果对象
        resultUserMenuDto.Name = userInfo.Name;
        resultUserMenuDto.UserName = userInfo.UserName;
        resultUserMenuDto.Phone = userInfo.Phone;
        resultUserMenuDto.Email = userInfo.Email;
        //查询用户的角色
        RoleInfo roleInfo = await Context.Queryable<RoleInfo>().Where(r => r.RoleId == userInfo.RoleId).FirstAsync();
        if (roleInfo.IsEmpty())
            throw new Exception("获取用户角色失败，用户角色不存在");
        resultUserMenuDto.RoleCode = roleInfo.Code;
        resultUserMenuDto.RoleName = roleInfo.Name;
        //查询用户的角色菜单集合
        var resultMenuPowerList = await Context.Queryable<RoleMenuInfo, MenuInfo, MenuPowerInfo>((rm, m, mp) =>
      new JoinQueryInfos(JoinType.Inner, rm.MenuId == m.MenuId, JoinType.Inner, rm.MenuPowerId == mp.MenuPowerId))
          .Where((rm, m, mp) => rm.RoleId == userInfo.RoleId)
          .Select((rm, m, mp) => new ResultMenuPowerInfoDto
          {
              MenuId = m.MenuId,
              ParentId = m.ParentId,
              ParentName = m.ParentName,
              Name = m.Name,
              Number = m.Number,
              LevelCode = m.LevelCode,
              ComponentName = m.ComponentName,
              Icon = m.Icon,
              Url = m.Url,
              Router = m.Router,
              JumpUrl = m.JumpUrl,
              Show = m.Show,
              Close = m.Close,
              KeepAlive = m.KeepAlive,
              State = m.State,
              Description = m.Description,
              MenuPowerId = mp.MenuPowerId,
              Display = mp.Display,
              Insert = mp.Insert,
              Update = mp.Update,
              Delete = mp.Delete,
              Save = mp.Save,
              Search = mp.Search,
              Export = mp.Export,
              Print = mp.Print,
              Import = mp.Import,
              Operates = mp.Operates
          }).ToListAsync();

        var parentList = resultMenuPowerList.Where(l => l.ParentId.IsEmpty()); //一级菜单栏

        //取值：循环获取树状菜单
        List<MenusDto> Menus = new List<MenusDto>();//定义父级菜单
        List<MenusDto> children = new List<MenusDto>();//定义子级菜单
        foreach (var item in parentList)
        {
            var childrenList = resultMenuPowerList.Where(l => l.ParentId == item.MenuId);//二级菜单
            MenusDto menusDto = _MapsterHelp.MapEntity<ResultMenuPowerInfoDto, MenusDto>(item);
            children = _MapsterHelp.MapList<ResultMenuPowerInfoDto, MenusDto>(childrenList.ToList());
            foreach (var it in children)
            {
                it.children = new List<MenusDto>();
            }
            menusDto.children = children.OrderBy(l => l.LevelCode).ToList();
            Menus.Add(menusDto);
        }
        //赋值：将树状菜单信息赋给结果对象
        resultUserMenuDto.Menus = Menus.OrderBy(l => l.LevelCode).ToList();

        //取值:菜单权限
        List<MenuPowerInfoDto> MenuPowers = _MapsterHelp.MapList<ResultMenuPowerInfoDto, MenuPowerInfoDto>(resultMenuPowerList);

        //赋值：将菜单权限信息赋给结果对象
        resultUserMenuDto.MenuPowers = MenuPowers;

        return resultUserMenuDto;
    }
}
}
