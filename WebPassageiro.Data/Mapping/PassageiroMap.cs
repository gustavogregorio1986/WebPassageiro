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
    public class PassageiroMap : IEntityTypeConfiguration<Passageiro>
    {
        public void Configure(EntityTypeBuilder<Passageiro> builder)
        {
            builder.ToTable("tb_Passageiro");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.NomePassageiro)
                .IsRequired()
                .HasColumnType("VARCHAR(50)");

            builder.Property(p => p.Cpf)
                .IsRequired()
                .HasColumnType("VARCHAR(11)");

            builder.Property(p => p.Cidade)
                .IsRequired()
                .HasColumnType("VARCHAR(50)");

            builder.HasOne(p => p.Aviao)
                .WithOne(a => a.Passageiro)
                .HasForeignKey<Aviao>(a => a.passageiroId);
        }
    }
}
