using AnaliseClinica.Domain.Entities;
using AnaliseClinica.Domain.Repositories;
using System;

namespace AnaliseClinica.Infra.Repositories
{
    public class OrdemServicoExameRepository : IOrdemServicoExameRepository
    {
        private readonly AnaliseClinicaContext _context;

        public OrdemServicoExameRepository(AnaliseClinicaContext context)
        {
            _context = context;
        }

        public int Save(OrdemServicoExame ordemServicoExame)
        {
            try
            {
                _context.OrdemServicoExames.Add(ordemServicoExame);
                _context.SaveChanges();

                return ordemServicoExame.Id;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro interno. {ex.Message}");
            }
        }
    }
}
