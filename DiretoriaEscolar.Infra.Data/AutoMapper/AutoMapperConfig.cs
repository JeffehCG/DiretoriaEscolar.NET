using AutoMapper;
using DiretoriaEscolar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiretoriaEscolar.Infra.Data.AutoMapper
{
    class AutoMapperConfig<Departure, Destination>
    {
        private MapperConfiguration _config;

        public AutoMapperConfig()
        {
            Configure();
        }

        private void Configure()
        {
            _config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Escolas, Escola>();
                cfg.CreateMap<Turmas, Turma>();
                cfg.CreateMap<Alunos, Aluno>();
                cfg.CreateMap<Enderecos, Endereco>();

                cfg.CreateMap<Escola, Escolas>();
                cfg.CreateMap<Turma, Escolas>();
                cfg.CreateMap<Aluno, Escolas>();
                cfg.CreateMap<Endereco, Escolas>();

            });
        }

        public Destination MapClass(Departure obj)
        {
            IMapper IMapper = _config.CreateMapper();
            var objMappeado = IMapper.Map<Departure, Destination> (obj);
            return objMappeado;
        }

        public Departure MapClass(Destination obj)
        {
            IMapper IMapper = _config.CreateMapper();
            var objMappeado = IMapper.Map<Destination,Departure>(obj);
            return objMappeado;
        }
    }
}
