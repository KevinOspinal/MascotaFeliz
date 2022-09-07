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
        public string Nombre {get;set;}
        public string Apellido {get;set;}
        public string Direccion {get;set;}
        public int Telefono {get;set;}
   } 
}

