using AbpTodo.EntityFrameworkCore;

namespace AbpTodo.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly AbpTodoDbContext _context;

        public TestDataBuilder(AbpTodoDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}