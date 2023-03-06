using System;
using System.Threading.Tasks;
using Abp.TestBase;
using AbpTodo.EntityFrameworkCore;
using AbpTodo.Tests.TestDatas;

namespace AbpTodo.Tests
{
    public class AbpTodoTestBase : AbpIntegratedTestBase<AbpTodoTestModule>
    {
        public AbpTodoTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<AbpTodoDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<AbpTodoDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<AbpTodoDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<AbpTodoDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<AbpTodoDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<AbpTodoDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<AbpTodoDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<AbpTodoDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
