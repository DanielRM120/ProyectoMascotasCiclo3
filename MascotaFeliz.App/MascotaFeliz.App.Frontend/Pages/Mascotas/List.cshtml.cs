using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class ListModel : PageModel
    {
        private string[] mascotas={"Rex / Perro","Simba / Gato","Luna / Perro","Michi / Gato","Firulais / Perro"};

        public List<string> ListadeMascotas {get;set;}

        public void OnGet()
        {
            ListadeMascotas = new List<string>();
            ListadeMascotas.AddRange(mascotas);
        }
    }
}
