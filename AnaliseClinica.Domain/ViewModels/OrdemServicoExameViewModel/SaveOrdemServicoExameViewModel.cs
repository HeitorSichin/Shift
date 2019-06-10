using Flunt.Notifications;
using Flunt.Validations;
using System;

namespace AnaliseClinica.Domain.ViewModels.OrdemServicoExameViewModel
{
    public class SaveOrdemServicoExameViewModel : Notifiable, IValidatable
    {
        public int Id { get; set; }
        public DateTime EntregaResultado { get; set; }
        public double Preco { get; set; }
        public int OrdemServicoId { get; set; }
        public int ExameId { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                        .IsLowerOrEqualsThan(EntregaResultado, DateTime.Now, "EntregaResultado", "A data de entrega tem que ser igual ou maior que a data atual")
                        .IsLowerOrEqualsThan(Preco, 0, "Preco", "O preço tem que ser maior que zero.")
            );
        }
    }
}
