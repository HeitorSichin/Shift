using AnaliseClinica.Domain.Entities;
using AnaliseClinica.Domain.ViewModels.ExameViewModel;
using System.Collections.Generic;

namespace AnaliseClinica.Domain.Repositories
{
    public interface IExameRepository
    {
        IEnumerable<ListExameViewModel> GetAll();
        Exame GetById(int id);

    }
}
