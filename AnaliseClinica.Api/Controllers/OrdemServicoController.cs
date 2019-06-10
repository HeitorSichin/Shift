using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnaliseClinica.Domain.Entities;
using AnaliseClinica.Domain.Repositories;
using AnaliseClinica.Domain.ViewModels;
using AnaliseClinica.Domain.ViewModels.OrdemServicoViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AnaliseClinica.Api.Controllers
{
    [ApiController]
    public class OrdemServicoController : ControllerBase
    {
        private readonly IOrdemServicoRepository _ordemServicoRepository;
        private readonly IOrdemServicoExameRepository _ordemServicoExameRepository;

        public OrdemServicoController(IOrdemServicoRepository ordemServicoRepository
            , IOrdemServicoExameRepository ordemServicoExameRepository)
        {
            _ordemServicoRepository = ordemServicoRepository;
            _ordemServicoExameRepository = ordemServicoExameRepository;
        }

        [Route("v1/ordemservicos")]
        [HttpGet]
        public IEnumerable<ListOrdemServicoViewModel> Get() => _ordemServicoRepository.GetAll();


        [Route("v1/ordemservicos")]
        [HttpPost]
        public ResultViewModel Post([FromBody]SaveOrdemServicoViewModel model)
        {
            model.Validate();
            if (model.Invalid)
                return new ResultViewModel
                {
                    Success = false,
                    Message = "Não foi possível salvar a ordem de serviço.",
                    Data = model.Notifications
                };


            var ordemServico = _ordemServicoRepository.Save(model);

            return new ResultViewModel
            {
                Success = true,
                Message = "Ordem de serviço salvo com sucesso.",
                Data = ordemServico
            };

        }

    }
}