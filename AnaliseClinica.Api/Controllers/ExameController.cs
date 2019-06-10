using System.Collections.Generic;
using AnaliseClinica.Domain.Entities;
using AnaliseClinica.Domain.Repositories;
using AnaliseClinica.Domain.ViewModels.ExameViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AnaliseClinica.Api.Controllers
{
    [ApiController]
    public class ExameController : ControllerBase
    {
        private readonly IExameRepository _repository;

        public ExameController(IExameRepository repository)
        {
            _repository = repository;
        }

        [Route("v1/exames")]
        [HttpGet]
        public IEnumerable<ListExameViewModel> Get() => _repository.GetAll();

        [Route("v1/exames/{id}")]
        [HttpGet]
        public Exame Get(int id) => _repository.GetById(id);


    }
}