using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ray1.Services;

namespace ray1.Installers
{
    public class DbInstaller :IInstaller
    {

        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IPostService, PostService>();
        }
    }
}
