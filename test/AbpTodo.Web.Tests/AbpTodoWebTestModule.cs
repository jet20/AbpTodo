using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpTodo.Web.Startup;
namespace AbpTodo.Web.Tests
{
    [DependsOn(
        typeof(AbpTodoWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class AbpTodoWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpTodoWebTestModule).GetAssembly());
        }
    }
}