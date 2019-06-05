using System.Collections.Generic;

namespace AnaliseClinica.Domain.Entities
{
    public class Paciente
    {
        public int Id { get; set; }

        public string Nome { get; set; }
        public string Sexo { get; set; }

        public virtual Endereco Endereco { get; set; }
        public virtual IEnumerable<OrdemServico> OrdemServicos { get; set; }

    }
}
