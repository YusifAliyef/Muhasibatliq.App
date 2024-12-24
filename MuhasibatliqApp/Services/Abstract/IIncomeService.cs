using MuhasibatliqApp.Services.Dtos;
using MuhasibatliqApp.Wrappers.Interfaces;

namespace MuhasibatliqApp.Services.Abstract
{
    public interface IIncomeService
    {
        Task<bool> AddAsync(AddIncomeDto addIncomeDto);

        Task<IEnumerable<IncomeViewDto>> GetIncomeAsync();


        Task<bool> RemoveAsync(int id);
    }
}
