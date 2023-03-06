using Abp.Application.Services;

namespace AbpTodo
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class AbpTodoAppServiceBase : ApplicationService
    {
        protected AbpTodoAppServiceBase()
        {
            LocalizationSourceName = AbpTodoConsts.LocalizationSourceName;
        }
    }
}