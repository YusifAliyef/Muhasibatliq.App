namespace MuhasibatliqApp.Services.Dtos
{
    public class ExpenseViewDto
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public double ExpensesPrice { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
