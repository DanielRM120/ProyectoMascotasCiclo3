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
    public class LoginModel : PageModel
    {
        private readonly IRepositorioCliente repositorioClientes;

        [BindProperty]
        public Cliente Cliente { get; set; }

        public LoginModel()
        {
            this.repositorioClientes = new RepositorioCliente(new MascotaFeliz.App.Persistencia.AppContext());
        }


        public IActionResult OnGet(int? clientesId)
        {
            if (clientesId.HasValue)
            {
                Cliente = repositorioClientes.GetCliente(clientesId.Value);
            }
            else
            {
                Cliente = new Cliente();
            }
            if (Cliente == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }
    }
}
