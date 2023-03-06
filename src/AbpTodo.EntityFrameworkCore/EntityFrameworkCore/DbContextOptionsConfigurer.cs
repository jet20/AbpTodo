using Microsoft.EntityFrameworkCore;

namespace AbpTodo.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<AbpTodoDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for AbpTodoDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
