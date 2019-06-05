using AnaliseClinica.Domain.Entities;
using AnaliseClinica.Domain.Repositories;
using AnaliseClinica.Infra.ViewModels.CidadeViewModel;
using System.Collections.Generic;
using System.Linq;

namespace AnaliseClinica.Infra.Repositories
{
    public class CidadeRepository : ICidadeRepository
    {
        private readonly AnaliseClinicaContext _context;

        public CidadeRepository(AnaliseClinicaContext context)
        {
            _context = context;
        }

        public IEnumerable<Cidade> GetAll()
        {
            return _context.Cidades;
        }

        public Cidade GetById(int id)
        {
            return _context.Cidades.Find(id);
        }

        public void Save(Cidade cidade)
        {
            _context.Cidades.Add(cidade);
            _context.SaveChanges();
        }

        public void Update(Cidade cidade)
        {
            _context.Entry(cidade).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var cidade = _context.Cidades.Find(id);
            _context.Cidades.Remove(cidade);
            _context.SaveChanges();
        }

    }
}
