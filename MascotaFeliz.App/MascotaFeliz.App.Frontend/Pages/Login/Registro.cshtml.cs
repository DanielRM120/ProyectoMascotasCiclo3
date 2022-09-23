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
    public class RegistroModel : PageModel
    {
        private readonly IRepositorioCliente repositorioClientes;

        [BindProperty]
        public Cliente Cliente { get; set; }

        public RegistroModel()
        {
            this.repositorioClientes = new RepositorioCliente(new MascotaFeliz.App.Persistencia.AppContext());
        }


        public IActionResult OnPost()
        {
            
            repositorioClientes.AddCliente(Cliente);
            
            return Page();
        }
    }
}
