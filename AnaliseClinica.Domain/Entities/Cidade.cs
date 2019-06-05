using AnaliseClinica.Domain.Enums;
using System.Collections.Generic;

namespace AnaliseClinica.Domain.Entities
{
    public class Cidade
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public EUf UF { get; set; }

        public virtual IEnumerable<Endereco> Enderecos { get; set; }
    }
}
