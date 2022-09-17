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
    public class CrearVeterinariosModel : PageModel
    {
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
            
        //LLama al metodo
        public void OnGet()
        {
            var veterinario = new Veterinario{
                Cedula = "1084227555",
                Nombres = "Jhon",
                Apellidos = "Melo",
                Direccion ="Santa marta",
                Telefono = "3153181346",
                TarjetaProfesional = "MP-151216"
            };
            veterinario = _repoVeterinario.AddVeterinario(veterinario);
        }
    }
}
