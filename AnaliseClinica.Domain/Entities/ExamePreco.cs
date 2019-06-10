using System.Collections.Generic;

namespace AnaliseClinica.Domain.Entities
{
    public class ExamePreco
    {
        public int Id { get; set; }
        public double Preco { get; set; }

        public virtual Exame Exame { get; set; }
        public virtual Convenio Convenio { get; set; }

    }
}
