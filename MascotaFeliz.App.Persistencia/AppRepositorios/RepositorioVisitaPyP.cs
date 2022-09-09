// using System;
// using System.Collections.Generic;
// using System.Linq;
// using MascotaFeliz.App.Dominio;
// using Microsoft.EntityFrameworkCore;

// namespace MascotaFeliz.App.Persistencia
// {
//     // public class RepositorioVisitaPyP : IRepositorioVisitaPyP
//     // {

//     // }
//     public class RepositorioVisitaPyP:IRepositorioVisitaPyP
//     {
//         /// <summary>
//         /// Referencia al contexto de VisitaPyP
//         /// </summary>
//         //Atributo
//         private readonly AppContext _appContext;
//         /// <summary>
//         /// Metodo Constructor Utiiza 
//         /// Inyeccion de dependencias para indicar el contexto a utilizar
//         /// </summary>
//         /// <param name="appContext"></param>//
        
//         //Cuando se llame a RepositorioVisitaPyP debe llamar a AppContext
//         //Es el constructor
//         // public RepositorioVisitaPyP(AppContext appContext)
//         // {
//         //     _appContext = appContext;
//         // }

//         // public VisitaPyP AddVisitaPyP(VisitaPyP veterinario)
//         // {
//         //     var veterinarioAdicionado = _appContext.VisitaPyPs.Add(veterinario);
//         //     _appContext.SaveChanges();
//         //     return veterinarioAdicionado.Entity;
//         // }

//         // public void DeleteVisitaPyP(int idVisitaPyP)
//         // {
//         //     var veterinarioEncontrado = _appContext.VisitaPyPs.FirstOrDefault(d => d.Id == idVisitaPyP);
//         //     if (veterinarioEncontrado == null)
//         //         return;
//         //     _appContext.VisitaPyPs.Remove(veterinarioEncontrado);
//         //     _appContext.SaveChanges();
//         // }

//     //    public IEnumerable<VisitaPyP> GetAllVisitaPyPs()
//     //     {
//     //         return GetAllVisitaPyPs_();
//     //     }

//     //     public IEnumerable<VisitaPyP> GetVisitaPyPsPorFiltro(string filtro)
//     //     {
//     //         var veterinarios = GetAllVisitaPyPs(); // Obtiene todos los dueños
//     //         if (veterinarios != null)  //Si se tienen dueño
//     //         {
//     //             if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor o es diferente de String
//     //             {
//     //                 veterinarios = veterinarios.Where(s => s.Nombres.Contains(filtro));
//     //             }
//     //         }
//     //         return veterinarios;
//     //     }

//         // public IEnumerable<VisitaPyP> GetAllVisitaPyPs_()
//         // {
//         //     return _appContext.VisitaPyPs;
//         // }

//         // public VisitaPyP GetVisitaPyP(int idVisitaPyP)
//         // {
//         //     return _appContext.VisitaPyPs.FirstOrDefault(d => d.Id == idVisitaPyP);
//         // }

//     // public VisitaPyP UpdateVisitaPyP(VisitaPyP veterinario)
//     //     {
//     //         var veterinarioEncontrado = _appContext.VisitaPyPs.FirstOrDefault(d => d.Id == veterinario.Id);
//     //         if (veterinarioEncontrado != null)
//     //         {
//     //             veterinarioEncontrado.Nombres = veterinario.Nombres;
//     //             veterinarioEncontrado.Apellidos = veterinario.Apellidos;
//     //             veterinarioEncontrado.Direccion = veterinario.Direccion;
//     //             veterinarioEncontrado.Telefono = veterinario.Telefono;
//     //             veterinarioEncontrado.Correo = veterinario.Correo;
//     //             _appContext.SaveChanges();
//     //         }
//     //         return veterinarioEncontrado;
//     //     }
//     }
// }