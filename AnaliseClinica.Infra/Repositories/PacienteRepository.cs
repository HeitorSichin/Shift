using AnaliseClinica.Domain.Entities;
using AnaliseClinica.Domain.Repositories;
using AnaliseClinica.Domain.ViewModels.PacienteViewModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AnaliseClinica.Infra.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly AnaliseClinicaContext _context;

        public PacienteRepository(AnaliseClinicaContext context)
        {
            _context = context;
        }

        public IEnumerable<ListPacienteViewModel> GetAll()
        {
            return _context.Pacientes
                            .Select(c => new ListPacienteViewModel {
                                Id = c.Id,
                                Nome = c.Nome
                            })
                            .OrderBy(c => c.Nome)
                            .AsNoTracking()
                            .ToList();
        }

        public Paciente GetById(int id)
        {
            return _context.Pacientes.Find(id);
        }
    }
}
