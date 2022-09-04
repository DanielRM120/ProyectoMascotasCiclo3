using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MascotaFeliz.App.Dominio
{
    public class Persona
    {
        public int Id {get; set;}        
        public string Nombres {get; set;}
        public string Apellidos {get; set;}
        public string NumeroTelefono {get; set;}
        public string Direccion { get; set;}
        public string Correo { get; set; }
    }
}