using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MascotaFeliz.App.Dominio
{
    public class Vacuna
    {
        public int Id { get; set; }
        public string NombreVacuna { get; set; }
        public HistoriaClinica HistoriaClinica { get; set; }

    }
}