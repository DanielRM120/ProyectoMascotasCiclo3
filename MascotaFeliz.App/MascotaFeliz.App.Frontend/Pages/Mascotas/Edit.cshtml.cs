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
    public class EditModel : PageModel
    {
       private readonly IRepositorioMascota repositorioMascotas;

        [BindProperty]
        public Mascota Mascota  { get; set; } 

        public EditModel()
       {
            this.repositorioMascotas=new RepositorioMascota(new MascotaFeliz.App.Persistencia.AppContext());
       }
     

        public IActionResult OnGet(int? mascotasId)
        {
            if (mascotasId.HasValue)
            {
                Mascota = repositorioMascotas.GetMascota(mascotasId.Value);
            }
            else
            {
                Mascota = new Mascota();
            }
            if (Mascota == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Mascota.Id>0)
            {
            Mascota = repositorioMascotas.UpdateMascota(Mascota);
            }
            else
            {
             repositorioMascotas.AddMascota(Mascota);
            }
            return Page();
        }
    }
}
