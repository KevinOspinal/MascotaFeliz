//Esto es una INTERFAZ

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioHistoria
    {
        //Teoria de interfases, describen la firma de los metodos
        //firma es el nombre del metodo sin el cuerpo para saber como implementarla
        //Funcion CRUD para llamar desde otros archivos
        
        // IEnumerable tipo de estructura de datos que sirve para almacenar elementos de tipo Historia
        // IEnumerable<Historias> GetAllHistorias();
        Historia AddHistoria(Historia historia);
        // Historia UpdateHistoria(Historia historia);
        void DeleteHistoria(int idHistoria);
        // Historia GetHistoria(int idHistoria);
        // IEnumerable<Historia> GetHistoriaPorFiltro(String filtro);
    }
}