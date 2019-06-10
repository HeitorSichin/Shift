using AnaliseClinica.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnaliseClinica.Infra.Maps
{
    public class ExamePrecoMap : IEntityTypeConfiguration<ExamePreco>
    {
        public void Configure(EntityTypeBuilder<ExamePreco> builder)
        {
            builder.ToTable("ExamePreco");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseSqlServerIdentityColumn();
            builder.Property(x => x.Preco).IsRequired().HasColumnType("money");

            builder.HasOne(x => x.Exame).WithMany(x => x.ExamePrecos);
            builder.HasOne(x => x.Convenio).WithMany(x => x.ExamePrecos);

        }
    }
}
