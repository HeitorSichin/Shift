using AnaliseClinica.Domain.Entities;
using AnaliseClinica.Domain.Repositories;
using AnaliseClinica.Domain.ViewModels.PostoColetaViewModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AnaliseClinica.Infra.Repositories
{
    public class PostoColetaRepository : IPostoColetaRepository
    {
        private readonly AnaliseClinicaContext _context;

        public PostoColetaRepository(AnaliseClinicaContext context)
        {
            _context = context;
        }

        public IEnumerable<ListPostoColetaViewModel> GetAll()
        {
            return _context.PostoColetas
                            .Select(c => new ListPostoColetaViewModel
                            {
                                Id = c.Id,
                                Descricao = c.Descricao
                            })
                            .AsNoTracking()
                            .OrderBy(c => c.Descricao)
                            .ToList();
        }

        public PostoColeta GetById(int id)
        {
            return _context.PostoColetas.Find(id);
        }
    }
}
