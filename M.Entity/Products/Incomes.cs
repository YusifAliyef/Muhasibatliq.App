using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.Entity.Products
{
    public class Incomes:BaseEntity
    {
        public string ProjectName { get; set; }
        public double IncomePrice { get; set; }
    }
}
