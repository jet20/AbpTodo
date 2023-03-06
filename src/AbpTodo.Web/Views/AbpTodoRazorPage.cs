using Abp.AspNetCore.Mvc.Views;

namespace AbpTodo.Web.Views
{
    public abstract class AbpTodoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected AbpTodoRazorPage()
        {
            LocalizationSourceName = AbpTodoConsts.LocalizationSourceName;
        }
    }
}
