using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace AbpTodo.EntityFrameworkCore
{
    [DependsOn(
        typeof(AbpTodoCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class AbpTodoEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpTodoEntityFrameworkCoreModule).GetAssembly());
        }
    }
}