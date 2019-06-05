using System.Collections.Generic;

namespace AnaliseClinica.Domain.Entities
{
    public class Convenio
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public virtual IEnumerable<OrdemServico> OrdemServicos { get; set; }
        public virtual IEnumerable<ExamePreco> ExamePrecos { get; set; }
    }
}
