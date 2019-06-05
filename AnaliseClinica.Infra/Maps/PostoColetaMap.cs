using AnaliseClinica.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnaliseClinica.Infra.Maps
{
    public class PostoColetaMap : IEntityTypeConfiguration<PostoColeta>
    {
        public void Configure(EntityTypeBuilder<PostoColeta> builder)
        {
            builder.ToTable("PostoColeta");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseSqlServerIdentityColumn();
            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)");
            builder.HasOne(x => x.Endereco).WithMany(x => x.PostoColetas);
        }
    }
}
