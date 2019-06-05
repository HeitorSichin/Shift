using System.Collections.Generic;

namespace AnaliseClinica.Domain.Entities
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual Especialidade Especialidade { get; set; }

        public virtual IEnumerable<OrdemServico> OrdemServicos { get; set; }
    }
}
