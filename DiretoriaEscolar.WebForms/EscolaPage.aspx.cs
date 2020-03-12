using DiretoriaEscolar.WebForms.EscolaService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiretoriaEscolar.WebForms
{
    public partial class EscolaPage : System.Web.UI.Page
    {
        EscolaAppServiceClient escolaService = new EscolaAppServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            ListarEscolas();
        }

        protected void ListarEscolas()
        {
            IEnumerable<Escola> listaEscolas = new List<Escola>();
            listaEscolas = escolaService.GetAll();
        }
    }
}