using AnaliseClinica.Domain.Enums;
using Flunt.Notifications;
using Flunt.Validations;

namespace AnaliseClinica.Infra.ViewModels.CidadeViewModel
{
    public class SaveCidadeViewModel : Notifiable, IValidatable
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public EUf Uf { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract()
                    .HasMaxLen(Descricao, 200, "Descricao", "A descrição deve conter até 200 caracteres")
                    .HasMinLen(Descricao, 3, "Descricao","A descrição deve conter pelo menos 3 caracteres")
                    .HasLen(Uf.ToString(), 2, "Uf", "O estado deve conter 2 caracteres")
                );
        }
    }
}
