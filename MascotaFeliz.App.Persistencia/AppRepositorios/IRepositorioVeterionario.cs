//Esto es una INTERFAS

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioVeterinario
    {
        //Teoria de interfases, describen la firma de los metodos
        //Funcion CRUD para llamar desde otros archivos
        
        // IEnumerable tipo de estructura de datos que sirve para almacenar elementos de tipo Veterinario
        //IEnumerable<Veterinarios> GetAllVeterinarios();
        Veterinario AddVeterinario(Veterinario Veterinario);
        // Veterinario UpdateVeterinario(Veterinario dueno);
        void DeleteVeterinario(int idVeterinario);
        Veterinario GetVeterinario(int idVeterinario);
        // IEnumerable<Veterinario> GetVeterinarioPorFiltro(String filtro);
    }
}