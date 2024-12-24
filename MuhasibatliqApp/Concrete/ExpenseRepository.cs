using M.Entity.Products;
using MuhasibatliqApp.Abstract;
using MyFinanceApp.Data;

namespace MuhasibatliqApp.Concrete
{
    public class ExpenseRepository : GenericRepository<Expenses>, IExpenseRepository
    {
        public ExpenseRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
