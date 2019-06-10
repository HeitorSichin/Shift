using AnaliseClinica.Domain.Entities;
using AnaliseClinica.Domain.ViewModels.OrdemServicoViewModel;
using System.Collections.Generic;

namespace AnaliseClinica.Domain.Repositories
{
    public interface IOrdemServicoRepository
    {
        OrdemServico Save(SaveOrdemServicoViewModel ordemServico);
        IEnumerable<ListOrdemServicoViewModel> GetAll();
        OrdemServico GetById(int id);
    }
}
