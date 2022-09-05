using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola
{
    class Program
    {
        private static IRepositorioDueno _repoDueno = new RepositorioDueno (new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hola amigos vamos a trabajar en las tablas");
        }
        //agregar dueño
        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                Nombres = "Leonardo",
                Apellidos = "Rodriguez", 
                Direccion = "Calle 120",
                Telefono = "111258258",
                Correo = "Batman@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }
    }
}
