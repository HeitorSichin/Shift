using System;

namespace AnaliseClinica.Domain.Entities
{
    public class OrdemServicoExame
    {
        public int Id { get; set; }
        public DateTime EntregaResultado { get; set; }
        public double Preco { get; set; }

        public virtual OrdemServico OrdemServico { get; set; }
        public virtual Exame Exame { get; set; }
    }
}
