using M.Entity.Products;
using MuhasibatliqApp.Abstract;
using MyFinanceApp.Data;

namespace MuhasibatliqApp.Concrete
{
    public class IncomeRepository : GenericRepository<Incomes>, IIncomeRepository
    {
        public IncomeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
