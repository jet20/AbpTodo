using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AbpTodo.EntityFrameworkCore
{
    public class AbpTodoDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public AbpTodoDbContext(DbContextOptions<AbpTodoDbContext> options) 
            : base(options)
        {

        }
    }
}
