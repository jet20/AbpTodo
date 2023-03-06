using AbpTodo.Configuration;
using AbpTodo.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AbpTodo.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class AbpTodoDbContextFactory : IDesignTimeDbContextFactory<AbpTodoDbContext>
    {
        public AbpTodoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AbpTodoDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(AbpTodoConsts.ConnectionStringName)
            );

            return new AbpTodoDbContext(builder.Options);
        }
    }
}