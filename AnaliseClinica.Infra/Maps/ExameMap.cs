using AnaliseClinica.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnaliseClinica.Infra.Maps
{
    public class ExameMap : IEntityTypeConfiguration<Exame>
    {
        public void Configure(EntityTypeBuilder<Exame> builder)
        {
            builder.ToTable("Exame");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseSqlServerIdentityColumn();
            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(300).HasColumnType("varchar(300)");
            builder.Property(x => x.MaterialBiologico).IsRequired().HasMaxLength(300).HasColumnType("varchar(300)");
            builder.Property(x => x.Prazo).IsRequired().HasColumnType("int");
            builder.HasOne(x => x.Setor).WithMany(x => x.Exames);
        }
    }
}
