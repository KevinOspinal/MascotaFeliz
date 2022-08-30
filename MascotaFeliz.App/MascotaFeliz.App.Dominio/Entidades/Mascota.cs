//para importar se usa Using

using System;

//Espacio de nombres (componentes)

namespace MascotaFeliz.App.Dominio
{
    //crear clase y atributos
   public class Mascota
   {
        //primary key
        public int Id {get;set;}
        //Datos de la mascota
        public string Nombre {get;set;}
        public string Color {get;set;}
        public string Especie {get;set;}
        public string Raza {get;set;}

        //Relación entre Mascota y dueño
        public Dueno Dueno {get;set;}
        //Relación entre la mascota y el veterinario asignado
        public Veterinario Veterinario {get;set;}
        //Relación Historia 1:1
        public Historia Historia {get;set;}
   } 
}