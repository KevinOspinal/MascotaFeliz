using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic ;

namespace MascotaFeliz.App.Consola
{
    class Program
    {
        //IRepositorioDueño un interfas que define el tipo de repositorio, como decir String o Int 
        //_repoDueno: es una variable es una interfas que implementa los metodos en el Repositorio Dueno
        //RepositorioDueno: Esta llamando al constructor que pide al AppContext de la persistencia
        
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        private static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
        private static IRepositorioVisitaPyP _repoVisitaPyP = new RepositorioVisitaPyP(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Proceso Finalizado con Exito ;)");

            // AddDuenos();
            // AddVeterinario();
            AddMascota();
            // AddHistoria();
            // AddVisitaPyP();

            //DeleteDueno(5);
            // DeleteVeterinario(10);
            // DeleteHistoria(2);
            // DeleteVisitaPyP(2);

            // BuscarDueno(2);
            // BuscarVeterinario(6);
            // BuscarHistoria(2);



            // GetAllDuenos();
            
            //ListarDuenosFiltro();
            //ListarVeterinariosFiltro();

        }

        //Inicio de metodos de Adicion

        private static void AddDuenos()
        {
            var dueno = new Dueno{
                Nombres = "Nathalia ",
                Apellidos = "Valenzuela",
                Direccion ="Mijitayo",
                Telefono = "3226120393",
                Correo = "Valenzuela@gmail.com"
            };
            //Llamemos a _repoDueno para asignarle el metodo AddDueno
            _repoDueno.AddDueno(dueno);
        }

        private static void AddVeterinario()
        {
            var veterinario = new Veterinario{
                Nombres = "Jorge ",
                Apellidos = "Riascos",
                Direccion ="Palermo",
                Telefono = "3155177489",
                TarjetaProfesional = "MP-521456"
            };
            //Llamemos a _repoDueno para asignarle el metodo AddDueno
            _repoVeterinario.AddVeterinario(veterinario);
        }

        private static void AddMascota()
        {
            var mascota = new Mascota{
                Nombre = "Bruno ",
                Color = "Blanco",
                Especie ="Macho",
                Raza = "Frech",
                // Duenio = 2,
                // int Veterinario = 8,
                // int Historia = 2
  
            };
            //Llamemos a _repoDueno para asignarle el metodo AddDueno
            _repoMascota.AddMascota(mascota);
        }

        public static void AddHistoria()
        {
            var historia = new Historia{
                FechaInicial = new DateTime(2000,05,12)
            };
            _repoHistoria.AddHistoria(historia);
        }


        private static void AddVisitaPyP()
        {
            var visitaPyP = new VisitaPyP{
                FechaVisita = new DateTime(2022,07,30),
                Temperatura = 36.5f,
                Peso = 15f,
                FrecuenciaRespiratoria = 80f,
                FrecuenciaCardiaca = 120f,
                EstadoAnimo = "Activo",
                // Historia = "Clinica",
                // IdVeterinario = "Veterinario",
                Recomendaciones = "Reposo por 7 dias"
                
            };
            //Llamemos a _repoDueno para asignarle el metodo AddDueno
            _repoVisitaPyP.AddVisitaPyP(visitaPyP);
        }

        // Metodos de Borrado

        private static void DeleteDueno(int idDueno)
        {
            var dueno = _repoDueno.GetDueno(idDueno);
            Console.WriteLine("Se a borro a "+dueno.Nombres+" "+dueno.Apellidos);
            _repoDueno.DeleteDueno(idDueno);
        }

        private static void DeleteVeterinario(int idVeterinario)
        {
            var veterinario = _repoVeterinario.GetVeterinario(idVeterinario);
            Console.WriteLine("Se a borro a "+veterinario.Nombres+" "+veterinario.Apellidos);
            _repoVeterinario.DeleteVeterinario(idVeterinario);
        }

        // private static void DeleteVisitaPyP(int idVisitaPyP)
        // {
        //     var visitaPyP = _repoVisitaPyP.GetVisitaPyP(idVisitaPyP);
        //     // Console.WriteLine("Se a borro a "+veterinario.Nombres+" "+veterinario.Apellidos);
        //     _repoVisitaPyP.DeleteVisitaPyP(idVisitaPyP);
        // }

        // private static void DeleteHistoria(int idHistoria)
        // {
        //     var historia = _repoHistoria.GetHistoria(idHistoria);
        //     // Console.WriteLine("Se a borro a "+historia.id);
        //     _repoHistoria.DeleteHistoria(idHistoria);
        // }
        
        //Metodos de Busqueda

        private static void BuscarDueno(int idDueno)
        {
            var dueno = _repoDueno.GetDueno(idDueno);
            Console.WriteLine(dueno.Nombres+" "+dueno.Apellidos);
        }

        private static void BuscarVeterinario(int idVeterinario)
        {
            var veterinario = _repoVeterinario.GetVeterinario(idVeterinario);
            Console.WriteLine(veterinario.Nombres+" "+veterinario.Apellidos);
        }

        // private static void BuscarHistoria(int idHistoria)
        // {
        //     var historia = _repoHistoria.GetHistoria(idHistoria);
        //     Console.WriteLine(historia.id+" -- "+historia.FechaInicial);
        // }

        

        // private static void ListarDuenosFiltro()
        // {
        //     var duenoFiltro = _repoDueno.GetDuenosPorFiltro("nar");
        //     foreach (Dueno p in duenosFiltro)
        //     {
        //         Console.WriteLine(p.Nombres + " " + p.Apellidos);
        //     }
        // }

        // private static void ListarVeterinariosFiltro()
        // {
        //     var veterinariosFiltro = _repoVeterinarios.GetVeterinariosPorFiltro("e");
        //     foreach (Veterinarios p in veterinariosFiltro)
        //     {
        //         Console.WriteLine(p.Nombres + " " + p.Apellidos);
        //     }
        // }

        // private static void GetAllDuenos()
        // {
        //     var dueno = _repoDueno.GetDueno();
        //     Console.WriteLine(dueno);
        // }

    }
}
