using Microsoft.OpenApi.Models;

namespace Web.Api.Extensions;
public static class SwaggerServiceExtensions
{
    public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services)
    {
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "E-Commerece App", Version = "1" });
        });
        return services;
    }
    public static IApplicationBuilder UseSwaggerDocumention (this IApplicationBuilder app)
    {
        app.UseSwagger();
        app.UseSwaggerUI();

        return app;
    } 
}
