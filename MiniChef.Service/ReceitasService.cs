using MiniChef.Domain.IRepository;
using MiniChef.Domain.IService;

namespace MiniChef.Service
{
    public class ReceitasService : IReceitasService
    {   //conexão entre o service e o repositório

        private IReceitasRepository _repository;
        public ReceitasService(IReceitasRepository repository)
        {
            _repository = repository;
        }

       
    }
}