namespace MuhasibatliqApp.Services.Dtos
{
    public class AddIncomeDto
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public double IncomePrice { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
