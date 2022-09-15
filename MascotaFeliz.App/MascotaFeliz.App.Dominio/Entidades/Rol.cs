using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MascotaFeliz.App.Dominio
{
    /// <summary>
    /// Se utilizara para el Login
    /// </summary>
    public class Rol : Usuario
    {
        

        public string Salt { get; set; }

        
        public string Nombre { get; set; }

       
        public string Apellidos { get; set; }

        
        public string Tipo { get; set; }
    }
    
}