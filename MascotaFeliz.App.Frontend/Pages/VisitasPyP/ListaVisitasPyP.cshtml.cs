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
    public class ListaVisitasPyPModel : PageModel
    {
        private static IRepositorioVisitaPyP _repoVisitaPyP = new RepositorioVisitaPyP(new Persistencia.AppContext());
        //Se crea una propiedad
        public IEnumerable<VisitaPyP> listaVisitasPyP {get;set;}
    
        //LLama al metodo
        public void OnGet()
        {
            listaVisitasPyP = _repoVisitaPyP.GetAllVisitasPyP();
        }
    }
}
