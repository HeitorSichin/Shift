using AnaliseClinica.Domain.Entities;
using System.Collections.Generic;

namespace AnaliseClinica.Domain.Repositories
{
    public interface ICidadeRepository
    {
        void Save(Cidade cidade);
        void Update(Cidade cidade);
        void Delete(int id);
        Cidade GetById(int id);
        IEnumerable<Cidade> GetAll();

    }
}
