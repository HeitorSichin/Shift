using System.Collections.Generic;
using AnaliseClinica.Domain.Entities;
using AnaliseClinica.Domain.Repositories;
using AnaliseClinica.Domain.ViewModels.MedicoViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AnaliseClinica.Api.Controllers
{
    [ApiController]
    public class MedicoController : ControllerBase
    {
        private readonly IMedicoRepository _repository;

        public MedicoController(IMedicoRepository repository)
        {
            _repository = repository;
        }

        [Route("v1/medicos")]
        [HttpGet]
        public IEnumerable<ListMedicoViewModel> Get() => _repository.GetAll();

        [Route("v1/medicos/{id}")]
        [HttpGet]
        public Medico Get(int id) => _repository.GetById(id);

    }
}