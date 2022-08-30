using System;
using System.Collections.Generic;

namespace MascotaFeliz.App.Dominio
{
    public class Historia
    {   
        //primary key
        public int Id {get;set;}
        //Fecha de realización de la historia clínica
        public DateTime FechaInicial {get;set;}
        //Lista para obtener y hacer consultas 1:m
        public List<VisitaPyP> VisitasPyP {get;set;}
    }
}