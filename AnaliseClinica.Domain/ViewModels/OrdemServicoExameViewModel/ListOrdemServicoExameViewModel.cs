using System;

namespace AnaliseClinica.Domain.ViewModels.OrdemServicoExameViewModel
{
    public class ListOrdemServicoExameViewModel
    {
        public int Id { get; set; }
        public int OrdemServicoId { get; set; }
        public int ExameId { get; set; }
        public string Exame { get; set; }
        public DateTime Entrega { get; set; }
        public double Preco { get; set; }
    }
}
