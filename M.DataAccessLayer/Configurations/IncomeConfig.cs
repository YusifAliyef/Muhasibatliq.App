using M.Entity.Products;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.DataAccessLayer.Configurations
{
    public class IncomeConfig:BaseEntityConfig<Incomes>
    {
        public override void Configure(EntityTypeBuilder<Incomes> builder)
        {
            base.Configure(builder);
            builder.HasKey(e => e.Id);
            builder.Property(e => e.ProjectName).IsRequired().HasMaxLength(100);
            builder.Property(e => e.IncomePrice).IsRequired();
        }
    }
}
