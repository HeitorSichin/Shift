using System.Collections.Generic;
using AnaliseClinica.Domain.Entities;
using AnaliseClinica.Domain.Repositories;
using AnaliseClinica.Domain.ViewModels.PostoColetaViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AnaliseClinica.Api.Controllers
{
    [ApiController]
    public class PostoColetaController : ControllerBase
    {
        private readonly IPostoColetaRepository _repository;

        public PostoColetaController(IPostoColetaRepository repository)
        {
            _repository = repository;
        }

        [Route("v1/postocoletas")]
        [HttpGet]
        public IEnumerable<ListPostoColetaViewModel> Get()
        {
            return _repository.GetAll();
        }

        [Route("v1/postocoletas/{id}")]
        [HttpGet]
        public PostoColeta Get(int id)
        {
            return _repository.GetById(id);
        }

    }
}