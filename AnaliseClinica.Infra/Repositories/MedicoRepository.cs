using AnaliseClinica.Domain.Entities;
using AnaliseClinica.Domain.Repositories;
using AnaliseClinica.Domain.ViewModels.MedicoViewModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AnaliseClinica.Infra.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        private readonly AnaliseClinicaContext _context;

        public MedicoRepository(AnaliseClinicaContext context)
        {
            _context = context;
        }

        public IEnumerable<ListMedicoViewModel> GetAll()
        {
            return _context.Medicos
                            .Select(c => new ListMedicoViewModel
                            {
                                Id = c.Id,
                                Nome = c.Nome
                            })
                            .OrderBy(c => c.Nome)
                            .AsNoTracking()
                            .ToList();
        }

        public Medico GetById(int id)
        {
            return _context.Medicos.Find(id);
        }
    }
}
