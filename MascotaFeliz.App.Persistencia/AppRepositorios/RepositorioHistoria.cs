using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioHistoria : IRepositorioHistoria
    {
        /// <summary>
        /// Referencia al contexto de Historia
        /// </summary>
        //Atributo
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        
        //Cuando se llame a RepositorioHistoria debe llamar a AppContext
        //Es el constructor
        public RepositorioHistoria(AppContext appContext)
        {
            _appContext = appContext;
        }

        public Historia AddHistoria(Historia historia)
        {
            var historiaAdicionado = _appContext.Historias.Add(historia);
            _appContext.SaveChanges();
            return historiaAdicionado.Entity;
        }

        public void DeleteHistoria(int idHistoria)
        {
            var historiaEncontrado = _appContext.Historias.FirstOrDefault(d => d.Id == idHistoria);
            if (historiaEncontrado == null)
                return;
            _appContext.Historias.Remove(historiaEncontrado);
            _appContext.SaveChanges();
        }

    //    public IEnumerable<Historia> GetAllHistorias()
    //     {
    //         return GetAllHistorias_();
    //     }

    //     public IEnumerable<Historia> GetHistoriasPorFiltro(string filtro)
    //     {
    //         var historias = GetAllHistorias(); // Obtiene todos los dueños
    //         if (historias != null)  //Si se tienen dueño
    //         {
    //             if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor o es diferente de String
    //             {
    //                 historias = historias.Where(s => s.Nombres.Contains(filtro));
    //             }
    //         }
    //         return historias;
    //     }

        // public IEnumerable<Historia> GetAllHistorias_()
        // {
        //     return _appContext.Historias;
        // }

        // public Historia GetHistoria(int idHistoria)
        // {
        //     return _appContext.Historias.FirstOrDefault(d => d.Id == idHistoria);
        // }

    // public Historia UpdateHistoria(Historia historia)
    //     {
    //         var historiaEncontrado = _appContext.Historias.FirstOrDefault(d => d.Id == historia.Id);
    //         if (historiaEncontrado != null)
    //         {
    //             historiaEncontrado.Nombres = historia.Nombres;
    //             historiaEncontrado.Apellidos = historia.Apellidos;
    //             historiaEncontrado.Direccion = historia.Direccion;
    //             historiaEncontrado.Telefono = historia.Telefono;
    //             historiaEncontrado.Correo = historia.Correo;
    //             _appContext.SaveChanges();
    //         }
    //         return historiaEncontrado;
    //     }
    }
}