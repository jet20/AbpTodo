using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpTodo.Localization;

namespace AbpTodo
{
    public class AbpTodoCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            AbpTodoLocalizationConfigurer.Configure(Configuration.Localization);
            
            Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = AbpTodoConsts.DefaultPassPhrase;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpTodoCoreModule).GetAssembly());
        }
    }
}