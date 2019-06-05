using System.Collections;
using System.Collections.Generic;

namespace AnaliseClinica.Domain.Entities
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }

        public virtual Cidade Cidade { get; set; }

        public virtual IEnumerable<PostoColeta> PostoColetas { get; set; }
        public virtual IEnumerable<Paciente> Pacientes { get; set; }
    }
}
