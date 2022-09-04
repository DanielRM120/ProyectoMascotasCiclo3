using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MascotaFeliz.App.Dominio
{
    public class Agenda
    {        
        public int Id { get; set; }
        public Veterinario Veterinario { get; set; } //Relacionado con Veterinario
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public Boolean Reserva { get; set; }

    }
}