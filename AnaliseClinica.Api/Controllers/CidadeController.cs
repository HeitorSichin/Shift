using System.Collections.Generic;
using AnaliseClinica.Domain.Entities;
using AnaliseClinica.Domain.Repositories;
using AnaliseClinica.Domain.ViewModels;
using AnaliseClinica.Domain.ViewModels.CidadeViewModel;
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
        public IEnumerable<ListCidadeViewModel> Get()
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

        [Route("v1/cidades")]
        [HttpPut]
        public ResultViewModel Put([FromBody]SaveCidadeViewModel model)
        {
            model.Validate();
            if (model.Invalid)
                return new ResultViewModel
                {
                    Success = false,
                    Message = "Não possível salvar a cidade",
                    Data = model.Notifications
                };

            var cidade = _repository.GetById(model.Id);
            if (cidade == null)
                return new ResultViewModel
                {
                    Success = false,
                    Message = "Cidade não encontrada",
                    Data = null
                };

            cidade.Descricao = model.Descricao;
            cidade.UF = model.Uf;
            _repository.Update(cidade);

            return new ResultViewModel
            {
                Success = true,
                Message = "Cidade salva com sucesso",
                Data = new { cidade.Id, cidade.Descricao }
            };
        }

        [Route("v1/cidades")]
        [HttpDelete]
        public ResultViewModel Delete([FromBody]Cidade model)
        {
            _repository.Delete(model);

            return new ResultViewModel
            {
                Success = true,
                Message = "Cidade excluida com sucesso",
                Data = null
            };
        }
    }
}