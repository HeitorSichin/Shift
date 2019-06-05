using AnaliseClinica.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnaliseClinica.Infra.Maps
{
    public class OrdemServicoMap : IEntityTypeConfiguration<OrdemServico>
    {
        public void Configure(EntityTypeBuilder<OrdemServico> builder)
        {
            builder.ToTable("OrdemServico");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseSqlServerIdentityColumn();
            builder.Property(x => x.Data).IsRequired().HasColumnType("date");
            builder.HasOne(x => x.Paciente).WithMany(x => x.OrdemServicos);
            builder.HasOne(x => x.Convenio).WithMany(x => x.OrdemServicos);
            builder.HasOne(x => x.PostoColeta).WithMany(x => x.OrdemServicos);
            builder.HasOne(x => x.Medico).WithMany(x => x.OrdemServicos);
        }
    }
}
