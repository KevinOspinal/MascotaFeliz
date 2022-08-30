//para importar se usa Using

using System;

//Espacio de nombres (componentes)

namespace MascotaFeliz.App.Dominio
{
    //crear clase y atributos
   public class Persona
   {
     //primary key
        public int Id {get;set;}
        public string Nombres {get;set;}
        public string Apellidos {get;set;}
        public string Direccion {get;set;}
        public int Telefono {get;set;}
   } 
}

