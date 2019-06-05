using System.Collections.Generic;

namespace AnaliseClinica.Domain.Entities
{
    public class Setor
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public virtual IEnumerable<Exame> Exames { get; set; }
    }
}
