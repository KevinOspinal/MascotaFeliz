using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioMascota : IRepositorioMascota
    {
        /// <summary>
        /// Referencia al contexto de Mascota
        /// </summary>
        //Atributo
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        
        //Cuando se llame a RepositorioMascota debe llamar a AppContext
        //Es el constructor
        public RepositorioMascota(AppContext appContext)
        {
            _appContext = appContext;
        }

        public Mascota AddMascota(Mascota mascota)
        {
            var mascotaAdicionado = _appContext.Mascotas.Add(mascota);
            _appContext.SaveChanges();
            return mascotaAdicionado.Entity;
        }

        public void DeleteMascota(int idMascota)
        {
            var mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(d => d.Id == idMascota);
            if (mascotaEncontrado == null)
                return;
            _appContext.Mascotas.Remove(mascotaEncontrado);
            _appContext.SaveChanges();
        }

       public IEnumerable<Mascota> GetAllMascotas()
        {
            return GetAllMascotas_();
        }

        public IEnumerable<Mascota> GetMascotaPorFiltro(string filtro)
        {
            var mascotas = GetAllMascotas(); // Obtiene todos los dueños
            if (mascotas != null)  //Si se tienen dueño
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor o es diferente de String
                {
                    mascotas = mascotas.Where(s => s.Nombre.Contains(filtro));
                }
            }
            return mascotas;
        }

        public IEnumerable<Mascota> GetAllMascotas_()
        {
            return _appContext.Mascotas;
        }

        public Mascota GetMascota(int idMascota)
        {
            return _appContext.Mascotas.FirstOrDefault(d => d.Id == idMascota);
        }

    // public Mascota UpdateMascota(Mascota mascota)
    //     {
    //         var mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(d => d.Id == mascota.Id);
    //         if (mascotaEncontrado != null)
    //         {
    //             mascotaEncontrado.Nombres = mascota.Nombres;
    //             mascotaEncontrado.Apellidos = mascota.Apellidos;
    //             mascotaEncontrado.Direccion = mascota.Direccion;
    //             mascotaEncontrado.Telefono = mascota.Telefono;
    //             mascotaEncontrado.Correo = mascota.Correo;
    //             _appContext.SaveChanges();
    //         }
    //         return mascotaEncontrado;
    //     }
    }
}