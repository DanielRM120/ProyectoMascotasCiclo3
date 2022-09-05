using System;
using System.Collections.Generic;
using MascotaFeliz.App.Dominio;
using System.Linq;


namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioVeterinario : IRepositorioVeterinario

    {
       private readonly AppContext _appContext;


        public RepositorioVeterinario(AppContext appContext)
        {
            _appContext = appContext;
        }


        public Veterinario AddVeterinario(Veterinario Veterinario)
        {
            var VeterinarioAdicionado = _appContext.Veterinarios.Add(Veterinario);
            _appContext.SaveChanges();
            return VeterinarioAdicionado.Entity;
        }


        public void DeleteVeterinario(int idVeterinario)
        {
            var VeterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(p => p.Id == idVeterinario);
            if (VeterinarioEncontrado == null)
                return;
            _appContext.Veterinarios.Remove(VeterinarioEncontrado);
            _appContext.SaveChanges();
        }


        public IEnumerable<Veterinario> GetAllVeterinario()
        {
            return _appContext.Veterinarios;
        }

        public Veterinario UpdateVeterinario(Veterinario Veterinario)
        {
            var VeterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(p => p.Id == Veterinario.Id);
            if (VeterinarioEncontrado != null)
            {   
                VeterinarioEncontrado.Nombres = Veterinario.Nombres;
                VeterinarioEncontrado.Apellidos = Veterinario.Apellidos;
                VeterinarioEncontrado.NumeroTelefono = Veterinario.NumeroTelefono;
                VeterinarioEncontrado.Direccion = Veterinario.Direccion;
                VeterinarioEncontrado.Correo = Veterinario.Correo;
                VeterinarioEncontrado.TarjetaProfesional = Veterinario.TarjetaProfesional;
                _appContext.SaveChanges();
            }
            return VeterinarioEncontrado;
        }

        public Veterinario GetVeterinario(int idVeterinario)
        {
            return _appContext.Veterinarios.FirstOrDefault(p => p.Id == idVeterinario);
        }
    }
}