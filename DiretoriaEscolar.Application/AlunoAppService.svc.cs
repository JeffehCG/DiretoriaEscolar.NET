using DiretoriaEscolar.Domain.Entities;
using DiretoriaEscolar.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace DiretoriaEscolar.Application
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AlunoAppService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AlunoAppService.svc or AlunoAppService.svc.cs at the Solution Explorer and start debugging.
    public class AlunoAppService : IAlunoAppService
    {
        private readonly IAlunoService _alunoService;
        public AlunoAppService(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }
        public void Add(Aluno obj)
        {
            _alunoService.Add(obj);
        }

        public void Dispose()
        {
            _alunoService.Dispose();
        }

        public IEnumerable<Aluno> GetAll()
        {
            return _alunoService.GetAll();
        }

        public Aluno GetById(int id)
        {
            return _alunoService.GetById(id);
        }

        public void Remove(Aluno obj)
        {
            _alunoService.Remove(obj);
        }

        public void Update(Aluno obj)
        {
            _alunoService.Update(obj);
        }
    }
}
