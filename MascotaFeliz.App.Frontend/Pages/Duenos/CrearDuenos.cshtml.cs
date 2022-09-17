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
                Cedula = "36752299",
                Nombres = "Sandra",
                Apellidos = "Maya",
                Direccion ="Pasto",
                Telefono = "3003214459",
                Correo = "sandramaya@gmail.com"
            };
            dueno = _repoDueno.AddDueno(dueno);
        }
        
    }
}
