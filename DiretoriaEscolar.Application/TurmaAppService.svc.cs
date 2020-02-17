using DiretoriaEscolar.Domain.Entities;
using DiretoriaEscolar.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace DiretoriaEscolar.Application
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TurmaAppService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TurmaAppService.svc or TurmaAppService.svc.cs at the Solution Explorer and start debugging.
    public class TurmaAppService : ITurmaAppService
    {
        private readonly ITurmaService _turmaService;
        public TurmaAppService(ITurmaService turmaService)
        {
            _turmaService = turmaService;
        }
        public void Add(Turma obj)
        {
            _turmaService.Add(obj);
        }

        public void Dispose()
        {
            _turmaService.Dispose();
        }

        public IEnumerable<Turma> GetAll()
        {
            return _turmaService.GetAll();
        }

        public Turma GetById(int id)
        {
            return _turmaService.GetById(id);
        }

        public void Remove(Turma obj)
        {
            _turmaService.Remove(obj);
        }

        public void Update(Turma obj)
        {
            _turmaService.Update(obj);
        }
    }
}
