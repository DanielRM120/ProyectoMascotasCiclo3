using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MascotaFeliz.App.Dominio
{
    /// <summary>
    /// Se utilizara para el Login
    /// </summary>
    public class Usuario
    {
        
        
        public int Id { get; set; }

       
        public byte[] Password { get; set; }

       
        public string Email { get; set; }

        
    }
}