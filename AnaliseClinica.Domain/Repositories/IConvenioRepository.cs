using AnaliseClinica.Domain.Entities;
using AnaliseClinica.Domain.ViewModels.ConvenioViewModel;
using System.Collections.Generic;

namespace AnaliseClinica.Domain.Repositories
{
    public interface IConvenioRepository
    {
        IEnumerable<ListConvenioViewModel> GetAll();
        Convenio GetById(int id);
    }
}
