namespace MuhasibatliqApp.Services.Dtos
{
    public class AddExpenseDto
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public double ExpensesPrice { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
