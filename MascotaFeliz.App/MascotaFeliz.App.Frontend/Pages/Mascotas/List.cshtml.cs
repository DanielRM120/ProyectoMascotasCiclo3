using System.Runtime.InteropServices;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class ListModel : PageModel
    {
        //private string[] mascotas={"Rex / Perro","Simba / Gato","Luna / Perro","Michi / Gato","Firulais / Perro"};
        private readonly IRepositorioMascota repositorioMascota;

        public IEnumerable<Mascota> ListaDeMascotas {get;set;}

        public ListModel()
       {
            this.repositorioMascota=new RepositorioMascota(new MascotaFeliz.App.Persistencia.AppContext());
       }

        public void OnGet()
        {
            //ListadeMascotas = new List<string>();
            //ListadeMascotas.AddRange(mascotas);

            ListaDeMascotas = repositorioMascota.GetAllMascota();
        }
    }
}
