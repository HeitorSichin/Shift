using AnaliseClinica.Domain.Entities;
using AnaliseClinica.Domain.Repositories;
using AnaliseClinica.Domain.ViewModels.ConvenioViewModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AnaliseClinica.Infra.Repositories
{
    public class ConvenioRepository : IConvenioRepository
    {
        private readonly AnaliseClinicaContext _context;

        public ConvenioRepository(AnaliseClinicaContext context)
        {
            _context = context;
        }

        public IEnumerable<ListConvenioViewModel> GetAll()
        {
            return _context.Convenios
                                .Select(c => new ListConvenioViewModel
                                {
                                    Id = c.Id,
                                    Descricao = c.Descricao
                                })
                                .OrderBy(c => c.Descricao)
                                .AsNoTracking()
                                .ToList();
        }

        public Convenio GetById(int id)
        {
            return _context.Convenios.Find(id);
        }
    }
}
