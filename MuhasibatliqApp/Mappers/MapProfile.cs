using AutoMapper;
using M.Entity.Products;
using Microsoft.VisualStudio.Services.Users;
using MuhasibatliqApp.Services.Dtos;

namespace MuhasibatliqApp.Mappers
{
    public class MapProfile : Profile
    {
     public MapProfile()
        
        
        {
            CreateMap<Expenses, ExpenseViewDto>();
            CreateMap<ExpenseViewDto, Expenses>();
            CreateMap<IncomeViewDto, Incomes>();
            CreateMap<Incomes, IncomeViewDto>();
            CreateMap<AddExpenseDto, Expenses>();
            CreateMap<Expenses, AddExpenseDto>();
            CreateMap<AddIncomeDto, Incomes>();


        }
    }
}