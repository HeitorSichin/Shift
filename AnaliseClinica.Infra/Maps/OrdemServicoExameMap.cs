using AnaliseClinica.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnaliseClinica.Infra.Maps
{
    public class OrdemServicoExameMap : IEntityTypeConfiguration<OrdemServicoExame>
    {
        public void Configure(EntityTypeBuilder<OrdemServicoExame> builder)
        {
            builder.ToTable("OrdemServicoExame");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseSqlServerIdentityColumn();
            builder.Property(x => x.EntregaResultado).IsRequired().HasColumnType("datetime");
            builder.Property(x => x.Preco).IsRequired().HasColumnType("money");
            builder.HasOne(x => x.OrdemServico).WithMany(x => x.OrdemServicoExames);
            builder.HasOne(x => x.Exame).WithMany(x => x.OrdemServicoExames);

        }
    }
}
