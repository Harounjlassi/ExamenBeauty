using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Exam.Infrastructure.Configurations
{
    public class RDVConfiguration : IEntityTypeConfiguration<RDV>
    {
        public void Configure(EntityTypeBuilder<RDV> builder)//builder=RDV
        {
            //config de clientFk <=> [foreifnKey("ClientFk")
            //si on depart from the client  HasMany(RDVs).WithOne(client)
            builder.HasOne(rdv => rdv.Client).
                WithMany(cl=> cl.RDVs).HasForeignKey(c => c.ClientFk);
            builder.HasOne(rdv => rdv.Prestation).
               WithMany(pre => pre.RDVs).HasForeignKey(c => c.PrestationFk);

            //config de cle primaire de table porteuse only par fluent API
            //r.Client.Id=r.ClientFk
            builder.HasKey(r => new { r.ClientFk, r.PrestationFk, r.DateRDV });
        }
    }
}
