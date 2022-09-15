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
    public class CrearDuenosModel : PageModel
    {

        //Constructor
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
            
        //LLama al metodo
        public void OnGet()
        {
            var dueno = new Dueno{
                Cedula = "1084227555",
                Nombres = "christian",
                Apellidos = "Eraso",
                Direccion ="Pasto",
                Telefono = "31653184662",
                Correo = "wilsoneraso@gmail.com"
            };
            dueno = _repoDueno.AddDueno(dueno);
        }
        
    }
}
