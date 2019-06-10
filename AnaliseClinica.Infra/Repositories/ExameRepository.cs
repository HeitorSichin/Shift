using AnaliseClinica.Domain.Entities;
using AnaliseClinica.Domain.Repositories;
using AnaliseClinica.Domain.ViewModels.ExameViewModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AnaliseClinica.Infra.Repositories
{
    public class ExameRepository : IExameRepository
    {
        private readonly AnaliseClinicaContext _context;

        public ExameRepository(AnaliseClinicaContext context)
        {
            _context = context;
        }

        public IEnumerable<ListExameViewModel> GetAll()
        {
            return _context.Exames.Select(c => new ListExameViewModel {
                Id = c.Id,
                Descricao = c.Descricao
            })
            .OrderBy(c => c.Descricao)
            .AsNoTracking().ToList();
        }

        public Exame GetById(int id)
        {
            return _context.Exames.Find(id);
        }
    }
}
