using System;
using System.Collections.Generic;

namespace AnaliseClinica.Domain.Entities
{
    public class OrdemServico
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }

        public virtual Paciente Paciente { get; set; }
        public virtual Convenio Convenio { get; set; }
        public virtual PostoColeta PostoColeta { get; set; }
        public virtual Medico Medico { get; set; }

        public virtual List<OrdemServicoExame> OrdemServicoExames { get; set; }
    }
}
