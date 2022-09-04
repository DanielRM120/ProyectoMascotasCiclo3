using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MascotaFeliz.App.Dominio
{
    public class Cliente : Persona
    {        
        public MedioDePago MedioDePago {get; set;}
        public Mascota Mascota { get; set; }


    }
}