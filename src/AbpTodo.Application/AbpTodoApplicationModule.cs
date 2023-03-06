using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace AbpTodo
{
    [DependsOn(
        typeof(AbpTodoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AbpTodoApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpTodoApplicationModule).GetAssembly());
        }
    }
}