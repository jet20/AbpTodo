using Abp.AspNetCore.Mvc.Controllers;

namespace AbpTodo.Web.Controllers
{
    public abstract class AbpTodoControllerBase: AbpController
    {
        protected AbpTodoControllerBase()
        {
            LocalizationSourceName = AbpTodoConsts.LocalizationSourceName;
        }
    }
}