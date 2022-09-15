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
    public class CrearMascotasModel : PageModel
    {
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        public void OnGet()
        {
            var mascota = new Mascota{
                Nombre = "Rex",
                Color = "Cafe",
                Especie ="Macho",
                Raza = "Golden"
            };
            mascota = _repoMascota.AddMascota(mascota);
        }
    }
}
