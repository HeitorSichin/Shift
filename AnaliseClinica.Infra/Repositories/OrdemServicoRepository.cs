using AnaliseClinica.Domain.Entities;
using AnaliseClinica.Domain.Repositories;
using AnaliseClinica.Domain.ViewModels.OrdemServicoViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AnaliseClinica.Infra.Repositories
{
    public class OrdemServicoRepository : IOrdemServicoRepository
    {
        private readonly AnaliseClinicaContext _context;

        public OrdemServicoRepository(AnaliseClinicaContext context)
        {
            _context = context;
        }

        public IEnumerable<ListOrdemServicoViewModel> GetAll()
        {
            return _context.OrdemServicos.Select(c => new ListOrdemServicoViewModel {
                Id = c.Id,
                Data = c.Data,
                NomeMedico = c.Medico.Nome,
                NomePaciente = c.Paciente.Nome,
                PostoColeta = c.PostoColeta.Descricao
            })
            .OrderByDescending(c => c.Id)
            .AsNoTracking()
            .ToList();
        }

        public OrdemServico GetById(int id)
        {
            return _context.OrdemServicos.Find(id);
        }

        public OrdemServico Save(SaveOrdemServicoViewModel model)
        {
            try
            {
                var ordemServico = new OrdemServico();
                ordemServico.Data = model.Data;
                ordemServico.Convenio = _context.Convenios.Where(c => c.Id == model.ConvenioId).FirstOrDefault();
                ordemServico.Paciente = _context.Pacientes.Where(c => c.Id == model.PacienteId).FirstOrDefault();
                ordemServico.PostoColeta = _context.PostoColetas.Where(c => c.Id == model.PostoColetaId).FirstOrDefault();
                ordemServico.Medico = _context.Medicos.Where(c => c.Id == model.MedicoId).FirstOrDefault();

                _context.OrdemServicos.Add(ordemServico);
                _context.SaveChanges();

                foreach (var item in model.Exames)
                {
                    var ordemServicoExame = new OrdemServicoExame();
                    ordemServicoExame.EntregaResultado = item.EntregaResultado;
                    ordemServicoExame.Preco = item.Preco;
                    ordemServicoExame.OrdemServico = _context.OrdemServicos.Where(c => c.Id == ordemServico.Id).FirstOrDefault();
                    ordemServicoExame.Exame = _context.Exames.Where(c => c.Id == item.ExameId).FirstOrDefault();
                    _context.OrdemServicoExames.Add(ordemServicoExame);
                }
                _context.SaveChanges();

                return ordemServico;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro interno. {ex.Message}");
            }
        }

    }
}
