using System.Collections.Generic;
using AnaliseClinica.Domain.Entities;
using AnaliseClinica.Domain.Repositories;
using AnaliseClinica.Domain.ViewModels.ConvenioViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AnaliseClinica.Api.Controllers
{
    [ApiController]
    public class ConvenioController : ControllerBase
    {
        private readonly IConvenioRepository _repository;

        public ConvenioController(IConvenioRepository repository)
        {
            _repository = repository;
        }

        [Route("v1/convenios")]
        [HttpGet]
        public IEnumerable<ListConvenioViewModel> Get() => _repository.GetAll();

        [Route("v1/convenios/{id}")]
        [HttpGet]
        public Convenio Get(int id) => _repository.GetById(id);

    }
}