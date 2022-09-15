using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class ListaHistoriasModel : PageModel
    {
        private static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());

        public IEnumerable<Historia> listaHistorias {get;set;}

        public void OnGet()
        {
            listaHistorias = _repoHistoria.GetAllHistorias();
        }
    }
}
