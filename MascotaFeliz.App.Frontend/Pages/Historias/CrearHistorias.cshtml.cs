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
    public class CrearHistoriasModel : PageModel
    {
        private static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
        
        public void OnGet()
        {
            var historia = new Historia{
            FechaInicial = new DateTime(2022,06,15)
            };
            
            _repoHistoria.AddHistoria(historia);
        }
    }
}
