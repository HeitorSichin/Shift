using System;

namespace AnaliseClinica.Domain.ViewModels.OrdemServicoViewModel
{
    public class ListOrdemServicoViewModel
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string NomePaciente { get; set; }
        public string PostoColeta { get; set; }
        public string NomeMedico { get; set; }
    }
}
