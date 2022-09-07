﻿using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;
namespace MascotaFeliz.App.Consola
{
    class Program
    {
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddDueno();
        }

        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                //Cedula = "1212",
                Nombre = "Juan",
                Apellido = "Sin Miedo",
                Direccion = "Bajo un puente",
                Telefono = 1234567891,
                Email = "juansinmiedo@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }
    }

    
}