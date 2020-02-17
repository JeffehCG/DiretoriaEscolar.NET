using DiretoriaEscolar.Domain.Interfaces.Repositories;
using DiretoriaEscolar.Domain.Interfaces.Services;
using DiretoriaEscolar.Domain.Services;
using DiretoriaEscolar.Infra.Data.Repositories;
using Ninject.Modules;

namespace DiretoriaEscolar.Application
{
    public class WCFNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IEscolaService>().To<EscolaService>();
            Bind<IEscolaRepository>().To<EscolaRepository>();

            Bind<IAlunoService>().To<AlunoService>();
            Bind<IAlunoRepository>().To<AlunoRepository>();

            Bind<ITurmaService>().To<TurmaService>();
            Bind<ITurmaRepository>().To<TurmaRepository>();

            Bind<IEnderecoService>().To<EnderecoService>();
            Bind<IEnderecoRepository>().To<EnderecoRepository>();
        }
    }
}