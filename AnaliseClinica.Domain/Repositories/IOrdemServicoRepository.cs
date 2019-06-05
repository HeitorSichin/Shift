using AnaliseClinica.Domain.Entities;
using System.Collections.Generic;

namespace AnaliseClinica.Domain.Repositories
{
    public interface IOrdemServicoRepository
    {
        bool Save(OrdemServico ordemServico);
        IEnumerable<OrdemServico> GetAll();
        OrdemServico GetById(int id);

    }
}
