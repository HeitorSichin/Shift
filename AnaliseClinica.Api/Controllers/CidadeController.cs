using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnaliseClinica.Domain.Entities;
using AnaliseClinica.Domain.Repositories;
using AnaliseClinica.Infra;
using AnaliseClinica.Infra.ViewModels;
using AnaliseClinica.Infra.ViewModels.CidadeViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AnaliseClinica.Api.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class CidadeController : ControllerBase
    {
        private readonly ICidadeRepository _repository;

        public CidadeController(ICidadeRepository repository)
        {
            _repository = repository;
        }

        [Route("v1/cidades")]
        [HttpGet]
        public IEnumerable<Cidade> Get()
        {
            return _repository.GetAll();
        }

        [Route("v1/cidades")]
        [HttpPost]
        public ResultViewModel Post([FromBody]SaveCidadeViewModel model)
        {
            model.Validate();
            if (model.Invalid)
                return new ResultViewModel
                {
                    Success = false,
                    Message = "Não possível salvar a cidade",
                    Data = model.Notifications
                };

            var cidade = new Cidade();
            cidade.Descricao = model.Descricao;
            cidade.UF = model.Uf;
            _repository.Save(cidade);

            return new ResultViewModel
            {
                Success = true,
                Message = "Cidade salva com sucesso",
                Data = cidade
            };
        }
    }
}