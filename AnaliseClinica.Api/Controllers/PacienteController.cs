using System.Collections.Generic;
using AnaliseClinica.Domain.Entities;
using AnaliseClinica.Domain.Repositories;
using AnaliseClinica.Domain.ViewModels.PacienteViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AnaliseClinica.Api.Controllers
{
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private readonly IPacienteRepository _repository;

        public PacienteController(IPacienteRepository repository)
        {
            _repository = repository;
        }

        [Route("v1/pacientes")]
        [HttpGet]
        public IEnumerable<ListPacienteViewModel> Get()
        {
            return _repository.GetAll();
        }

        [Route("v1/pacientes/{id}")]
        [HttpGet]
        public Paciente Get(int id)
        {
            return _repository.GetById(id);
        }
    }
}