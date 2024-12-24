using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.Entity.Products
{
    public class Expenses:BaseEntity
    {
        public string ProjectName { get; set; }
        public double ExpensesPrice { get; set; }
    }
}
