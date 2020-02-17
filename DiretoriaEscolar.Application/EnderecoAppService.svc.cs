using DiretoriaEscolar.Domain.Entities;
using DiretoriaEscolar.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace DiretoriaEscolar.Application
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EnderecoAppService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EnderecoAppService.svc or EnderecoAppService.svc.cs at the Solution Explorer and start debugging.
    public class EnderecoAppService : IEnderecoAppService
    {
        private readonly IEnderecoService _enderecoService;
        public EnderecoAppService(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }
        public void Add(Endereco obj)
        {
            _enderecoService.Add(obj);
        }

        public void Dispose()
        {
            _enderecoService.Dispose();
        }

        public IEnumerable<Endereco> GetAll()
        {
            return _enderecoService.GetAll();
        }

        public Endereco GetById(int id)
        {
            return _enderecoService.GetById(id);
        }

        public void Remove(Endereco obj)
        {
            _enderecoService.Remove(obj);
        }

        public void Update(Endereco obj)
        {
            _enderecoService.Update(obj);
        }
    }
}
