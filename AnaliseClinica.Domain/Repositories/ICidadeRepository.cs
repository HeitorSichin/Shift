using AnaliseClinica.Domain.Entities;
using AnaliseClinica.Domain.ViewModels.CidadeViewModel;
using System.Collections.Generic;

namespace AnaliseClinica.Domain.Repositories
{
    public interface ICidadeRepository
    {
        void Save(Cidade cidade);
        void Update(Cidade cidade);
        void Delete(Cidade cidade);
        Cidade GetById(int id);
        IEnumerable<ListCidadeViewModel> GetAll();

    }
}
