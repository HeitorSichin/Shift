using AnaliseClinica.Domain.Entities;
using AnaliseClinica.Domain.ViewModels.PostoColetaViewModel;
using System.Collections.Generic;

namespace AnaliseClinica.Domain.Repositories
{
    public interface IPostoColetaRepository
    {
        IEnumerable<ListPostoColetaViewModel> GetAll();
        PostoColeta GetById(int id);
    }
}
