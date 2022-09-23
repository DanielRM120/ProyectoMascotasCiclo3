using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioMascota repositorioMascotas;
        public Mascota Mascota { get; set; }

        public DetailsModel()
        {
            this.repositorioMascotas=new RepositorioMascota(new MascotaFeliz.App.Persistencia.AppContext());
        }

        public IActionResult OnGet(int MascotaId)
        {
            Mascota = repositorioMascotas.GetMascota(MascotaId);
            if(Mascota==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }
    }
}
