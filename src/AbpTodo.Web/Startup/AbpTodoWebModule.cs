using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpTodo.Configuration;
using AbpTodo.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;

namespace AbpTodo.Web.Startup
{
    [DependsOn(
        typeof(AbpTodoApplicationModule), 
        typeof(AbpTodoEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class AbpTodoWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public AbpTodoWebModule(IWebHostEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(AbpTodoConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<AbpTodoNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(AbpTodoApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpTodoWebModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(AbpTodoWebModule).Assembly);
        }
    }
}
