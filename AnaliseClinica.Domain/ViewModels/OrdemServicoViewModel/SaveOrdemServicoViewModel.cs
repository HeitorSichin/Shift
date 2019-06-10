using AnaliseClinica.Domain.ViewModels.OrdemServicoExameViewModel;
using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;

namespace AnaliseClinica.Domain.ViewModels.OrdemServicoViewModel
{
    public class SaveOrdemServicoViewModel : Notifiable, IValidatable
    {
        public SaveOrdemServicoViewModel()
        {
            Exames = new List<SaveOrdemServicoExameViewModel>();
        }

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int PostoColetaId { get; set; }
        public int PacienteId { get; set; }
        public int MedicoId { get; set; }
        public int ConvenioId { get; set; }

        public virtual IEnumerable<SaveOrdemServicoExameViewModel> Exames { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                       .IsGreaterOrEqualsThan(Data.Date, DateTime.Now.Date, "Data", "A data de entrega tem que ser igual ou maior que a data atual")
                       .IsGreaterThan(PacienteId, 0, "PacienteId", "O campo paciente tem o preenchimento obrigatório.")
            );
        }
    }
}
