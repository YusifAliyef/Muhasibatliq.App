using AutoMapper;
using M.Entity.Products;
using MuhasibatliqApp.Abstract;
using MuhasibatliqApp.Concrete;
using MuhasibatliqApp.Services.Abstract;
using MuhasibatliqApp.Services.Dtos;
using MuhasibatliqApp.Wrappers.Interfaces;

namespace MuhasibatliqApp.Services.Concrete
{
    public class IncomeService : IIncomeService
    {
        private readonly IIncomeRepository _incomeRepository;
        private readonly IMapper _mapper;

        public IncomeService(IIncomeRepository incomeRepository, IMapper mapper)
        {
            _incomeRepository = incomeRepository;
            _mapper = mapper;
        }

        public async Task<bool> AddAsync(AddIncomeDto addIncome)
        {
            try
            {
                var incomeEntity = _mapper.Map<Incomes>(addIncome);
                await _incomeRepository.AddAsync(incomeEntity);
                await _incomeRepository.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<IEnumerable<IncomeViewDto>> GetIncomeAsync()
        {
            var products = await _incomeRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<IncomeViewDto>>(products);
        }

        
        public async Task<bool> RemoveAsync(int id)
        {
            var expense = await _incomeRepository.GetByIdAsync(id);
            if (expense == null)
            {
                return false;
            }

            _incomeRepository.Remove(expense);

            try
            {
                await _incomeRepository.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}