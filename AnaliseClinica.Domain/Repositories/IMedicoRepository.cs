using AnaliseClinica.Domain.Entities;
using AnaliseClinica.Domain.ViewModels.MedicoViewModel;
using System.Collections.Generic;

namespace AnaliseClinica.Domain.Repositories
{
    public interface IMedicoRepository
    {
        IEnumerable<ListMedicoViewModel> GetAll();
        Medico GetById(int id);
    }
}
