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
    public class ListaDuenosModel : PageModel
    {
        //Constructor
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        //Se crea una propiedad
        public IEnumerable<Dueno> listaDuenos {get;set;}
    
        //LLama al metodo
        public void OnGet()
        {
            listaDuenos = _repoDueno.GetAllDuenos();
        }
    }
        
}