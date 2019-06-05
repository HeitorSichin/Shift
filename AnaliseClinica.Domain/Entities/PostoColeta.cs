using System.Collections.Generic;

namespace AnaliseClinica.Domain.Entities
{
    public class PostoColeta
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public virtual Endereco Endereco { get; set; }
        public virtual IEnumerable<OrdemServico> OrdemServicos { get; set; }
    }
}
