using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPassageiro.Dominio.Dominio;

namespace WebPassageiro.Data.Mapping
{
    public class AviaoMap : IEntityTypeConfiguration<Aviao>
    {
        public void Configure(EntityTypeBuilder<Aviao> builder)
        {
            builder.ToTable("tb_Aviao");
            
            builder.HasKey(a => a.Id);

            
        }
    }
}
