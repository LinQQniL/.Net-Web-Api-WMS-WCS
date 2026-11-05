# ---------- 第一阶段：编译 ----------
# 用 .NET 10 SDK 镜像把项目编译成发布文件
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# 先只拷贝 csproj 并还原 NuGet 包（利用缓存：代码没变时不用重新下载包）
COPY *.csproj ./
RUN dotnet restore

# 再拷贝全部代码并发布
COPY . .
RUN dotnet publish -c Release -o /app --no-restore

# ---------- 第二阶段：运行 ----------
# 只带运行时，镜像体积小
FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app
COPY --from=build /app .

# 容器内监听 8080 端口（.NET 8+ 镜像默认就是 8080，这里写明便于理解）
ENV ASPNETCORE_HTTP_PORTS=8080
EXPOSE 8080

ENTRYPOINT ["dotnet", "MiddlewareDemo.dll"]
