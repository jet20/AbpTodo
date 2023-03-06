using Microsoft.AspNetCore.Mvc;

namespace AbpTodo.Web.Controllers
{
    public class HomeController : AbpTodoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}