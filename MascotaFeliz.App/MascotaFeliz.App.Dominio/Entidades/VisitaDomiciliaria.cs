using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MascotaFeliz.App.Dominio
{
    public class VisitaDomiciliaria
    {
        public int Id { get; set; }        
        public int Temperatura { get; set; }
        public int Peso { get; set; }
        public int FrequienciaRespiratoria { get; set; }
        public int FrequienciaCardiaca { get; set; }
        public string EstadoAnimo { get; set; }
        public string Recomendaciones { get; set; }
        public HistoriaClinica HistoriaClinica { get; set; }
        public Veterinario Veterinario { get; set; }
        public Agenda Agenda { get; set; }

    }
}