//Esto es una INTERFAZ

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioDueno
    {
        //Teoria de interfases, describen la firma de los metodos
        //firma es el nombre del metodo sin el cuerpo para saber como implementarla
        //Funcion CRUD para llamar desde otros archivos
        
        // IEnumerable tipo de estructura de datos que sirve para almacenar elementos de tipo Dueno
        
        // IEnumerable<Duenos> GetAllDuenos();
        Dueno AddDueno(Dueno dueno);
        // Dueno UpdateDueno(Dueno dueno);
        void DeleteDueno(int idDueno);
        Dueno GetDueno(int idDueno);
        // IEnumerable<Dueno> GetDuenoPorFiltro(String filtro);
    }
}