using AutoMapper;
using FluentValidation;
using M.Entity.Products;
using MuhasibatliqApp.Abstract;
using MuhasibatliqApp.Enums;
using MuhasibatliqApp.Extentions;
using MuhasibatliqApp.Services.Abstract;
using MuhasibatliqApp.Services.Dtos;
using MuhasibatliqApp.Wrappers.Implementations;
using MuhasibatliqApp.Wrappers.Interfaces;

namespace MuhasibatliqApp.Services.Concrete
{
    public class ExpenseService : IExpenseService
    {
        private readonly IExpenseRepository _expenseRepository;
        private readonly IMapper _mapper;

        public ExpenseService(IExpenseRepository expenseRepository, IMapper mapper)
        {
            _expenseRepository = expenseRepository;
            _mapper = mapper;
        }

        public async Task<bool> AddAsync(AddExpenseDto expenseDto)
        {
            var expenseEntity = _mapper.Map<Expenses>(expenseDto);

            await _expenseRepository.AddAsync(expenseEntity);
            await _expenseRepository.SaveChangesAsync();

            return true;
        }



        public async Task<IEnumerable<ExpenseViewDto>> GetProductsAsync()
        {
            var products = await _expenseRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ExpenseViewDto>>(products);
        }
        public async Task<bool> RemoveAsync(int id)
        {
            var expense = await _expenseRepository.GetByIdAsync(id);
            if (expense == null)
            {
                return false; 
            }

            _expenseRepository.Remove(expense);
            await _expenseRepository.SaveChangesAsync();

            return true; 
        }


    }
}