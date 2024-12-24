using Microsoft.EntityFrameworkCore;
using MuhasibatliqApp.Abstract;
using MuhasibatliqApp.Components;
using MuhasibatliqApp.Concrete;
using MuhasibatliqApp.Services;
using MuhasibatliqApp.Services.Abstract;
using MuhasibatliqApp.Services.Concrete;
using MyFinanceApp.Data;
using System.Numerics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

string connectionString = builder.Configuration.GetConnectionString("local")!;
builder.Services
    .AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddScoped<IExpenseRepository, ExpenseRepository>();
builder.Services.AddScoped<IIncomeRepository, IncomeRepository>();
builder.Services.AddScoped<IExpenseService, ExpenseService>();
builder.Services.AddScoped<IIncomeService, IncomeService>();
builder.Services.AddAutoMapper(typeof(IBusinessRegister));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
