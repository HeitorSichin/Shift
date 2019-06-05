using AnaliseClinica.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AnaliseClinica.Infra.Maps
{
    public class CidadeMap : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.ToTable("Cidade");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseSqlServerIdentityColumn();
            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(200).HasColumnType("varchar(200)");
            builder.Property(x => x.UF).IsRequired().HasMaxLength(2).HasColumnType("char(2)");
        }

    }
}
