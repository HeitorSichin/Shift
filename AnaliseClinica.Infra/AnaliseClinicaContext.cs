using AnaliseClinica.Domain.Entities;
using AnaliseClinica.Infra.Maps;
using Microsoft.EntityFrameworkCore;

namespace AnaliseClinica.Infra
{
    public class AnaliseClinicaContext : DbContext
    {
        public AnaliseClinicaContext(DbContextOptions<AnaliseClinicaContext> options)
            :base (options) { }

        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Convenio> Convenios { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<Exame> Exames { get; set; }
        public DbSet<ExamePreco> ExamePrecos { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<OrdemServico> OrdemServicos { get; set; }
        public DbSet<OrdemServicoExame> OrdemServicoExames { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<PostoColeta> PostoColetas { get; set; }
        public DbSet<Setor> Setores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CidadeMap());
            modelBuilder.ApplyConfiguration(new ConvenioMap());
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new EspecialidadeMap());
            modelBuilder.ApplyConfiguration(new ExameMap());
            modelBuilder.ApplyConfiguration(new ExamePrecoMap());
            modelBuilder.ApplyConfiguration(new MedicoMap());
            modelBuilder.ApplyConfiguration(new OrdemServicoExameMap());
            modelBuilder.ApplyConfiguration(new OrdemServicoMap());
            modelBuilder.ApplyConfiguration(new PacienteMap());
            modelBuilder.ApplyConfiguration(new PostoColetaMap());
            modelBuilder.ApplyConfiguration(new SetorMap());
        }
    }
}
