using M.Entity.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.DataAccessLayer.Configurations
{
    public class ExpenseConfig : BaseEntityConfig<Expenses>
    {

        public override void Configure(EntityTypeBuilder<Expenses> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.ProjectName)
               .IsRequired();
            builder.Property(x => x.ExpensesPrice)
                .IsRequired();

        }
    }
}
