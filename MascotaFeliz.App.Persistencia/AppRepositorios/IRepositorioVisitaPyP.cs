//Esto es una INTERFAZ

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioVisitaPyP
    {
        //Teoria de interfases, describen la firma de los metodos
        //firma es el nombre del metodo sin el cuerpo para saber como implementarla
        //Funcion CRUD para llamar desde otros archivos
        
        // IEnumerable tipo de estructura de datos que sirve para almacenar elementos de tipo Dueno
        
        // IEnumerable<VisitaPyP> GetAllVisitaPyP();
        // VisitaPyP AddVisitaPyP(VisitaPyP visitaPyP);
        // VisitaPyP UpdateVisitaPyP(VisitaPyP visitaPyP);
        // void DeleteVisitaPyP(int idVisitaPyP);
        // VisitaPyP GetVisitaPyP(int idVisitaPyP);
        // IEnumerable<VisitaPyP> GetVisitaPyPPorFiltro(String filtro);
    }
}