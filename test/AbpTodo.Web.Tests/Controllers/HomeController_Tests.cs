using System.Threading.Tasks;
using AbpTodo.Web.Controllers;
using Shouldly;
using Xunit;

namespace AbpTodo.Web.Tests.Controllers
{
    public class HomeController_Tests: AbpTodoWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
