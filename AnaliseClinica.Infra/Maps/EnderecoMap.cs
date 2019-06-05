using AnaliseClinica.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnaliseClinica.Infra.Maps
{
    class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseSqlServerIdentityColumn();
            builder.Property(x => x.Logradouro).IsRequired().HasMaxLength(200).HasColumnType("varchar(200)");
            builder.Property(x => x.Bairro).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)");
            builder.HasOne(x => x.Cidade).WithMany(x => x.Enderecos);

        }
    }
}
