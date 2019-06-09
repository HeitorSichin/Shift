using AnaliseClinica.Domain.Entities;
using AnaliseClinica.Domain.ViewModels.PacienteViewModel;
using System.Collections.Generic;

namespace AnaliseClinica.Domain.Repositories
{
    public interface IPacienteRepository
    {
        IEnumerable<ListPacienteViewModel> GetAll();
        Paciente GetById(int id);
    }
}
