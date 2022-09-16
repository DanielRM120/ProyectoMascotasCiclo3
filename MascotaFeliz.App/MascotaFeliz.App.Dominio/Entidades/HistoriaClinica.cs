using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace MascotaFeliz.App.Dominio
{
    public class HistoriaClinica
    {
        public int Id { get; set; } 
        public Cliente Cliente { get; set; }
        public Mascota Mascota { get; set; }        
    }
}