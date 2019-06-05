using System.Collections.Generic;

namespace AnaliseClinica.Domain.Entities
{
    public class Exame
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string MaterialBiologico { get; set; }
        public int Prazo { get; set; }

        public virtual Setor Setor { get; set; }

        public virtual IEnumerable<ExamePreco> ExamePrecos { get; set; }
        public virtual IEnumerable<OrdemServicoExame> OrdemServicoExames { get; set; }
    }
}
