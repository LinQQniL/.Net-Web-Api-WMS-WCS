using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.OpenApi;

namespace MiddlewareDemo.Auth;

public class JwtSecuritySchemeTransformer : IOpenApiDocumentTransformer
{
	public Task TransformAsync(OpenApiDocument document, OpenApiDocumentTransformerContext context, CancellationToken cancellationToken)
	{
		OpenApiSecurityScheme value = new OpenApiSecurityScheme
		{
			Description = "请输入 JWT Token（不需要加 Bearer 前缀）",
			Name = "Authorization",
			In = ParameterLocation.Header,
			Type = SecuritySchemeType.Http,
			Scheme = "bearer",
			BearerFormat = "JWT"
		};
		OpenApiComponents openApiComponents;
		if (document.Components == null)
		{
			openApiComponents = (document.Components = new OpenApiComponents());
		}
		openApiComponents = document.Components;
		if (openApiComponents.SecuritySchemes == null)
		{
			IDictionary<string, IOpenApiSecurityScheme> dictionary = (openApiComponents.SecuritySchemes = new Dictionary<string, IOpenApiSecurityScheme>());
		}
		document.Components.SecuritySchemes["Bearer"] = value;
		OpenApiSecuritySchemeReference key = new OpenApiSecuritySchemeReference("Bearer", document);
		OpenApiSecurityRequirement item = new OpenApiSecurityRequirement { 
		{
			key,
			new List<string>()
		} };
		document.Security = new List<OpenApiSecurityRequirement> { item };
		return Task.CompletedTask;
	}
}
