using System.Collections.Generic;

namespace AnaliseClinica.Domain.Entities
{
    public class Especialidade
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public virtual IEnumerable<Medico> Medicos { get; set; }
    }
}
