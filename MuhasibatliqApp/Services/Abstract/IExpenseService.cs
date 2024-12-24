using MuhasibatliqApp.Services.Dtos;
using MuhasibatliqApp.Wrappers.Interfaces;

namespace MuhasibatliqApp.Services.Abstract
{
    public interface IExpenseService
    {
        Task<bool> AddAsync(AddExpenseDto expenseDto);

        Task<IEnumerable<ExpenseViewDto>> GetProductsAsync();

        
        Task<bool> RemoveAsync(int id);

    }
}
