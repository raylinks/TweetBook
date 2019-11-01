using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ray1.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace ray1.Installers
{
    public class MvcInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
           
           services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "Test Api",
                    Description = "ASP.NET Core web Api"
                });
            });
            services.AddControllers();
        }

       
    }
}
