using DiretoriaEscolar.Domain.Entities;
using DiretoriaEscolar.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Escola escola = new Escola();

            escola.Nome = "Teste1";
            escola.CNPJ = "12345678900";

            EscolaRepository db = new EscolaRepository();

            db.Add(escola);
        }
    }
}
