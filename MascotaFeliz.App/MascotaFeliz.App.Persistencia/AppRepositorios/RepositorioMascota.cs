using System;
using System.Collections.Generic;
using MascotaFeliz.App.Dominio;
using System.Linq;


namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioMascota : IRepositorioMascota

    {
        private readonly AppContext _appContext;


        public RepositorioMascota(AppContext appContext)
        {
            _appContext = appContext;
        }


        public Mascota AddMascota(Mascota Mascota)
        {
            var MascotaAdicionado = _appContext.Mascotas.Add(Mascota);
            _appContext.SaveChanges();
            return MascotaAdicionado.Entity;
        }


        public void DeleteMascota(int idMascota)
        {
            var MascotaEncontrado = _appContext.Mascotas.FirstOrDefault(p => p.Id == idMascota);
            if (MascotaEncontrado == null)
                return;
            _appContext.Mascotas.Remove(MascotaEncontrado);
            _appContext.SaveChanges();
        }


        public IEnumerable<Mascota> GetAllMascota()
        {
            return _appContext.Mascotas;
        }

        public Mascota UpdateMascota(Mascota mascota)
        {
            var mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(p => p.Id == mascota.Id);
            if (mascotaEncontrado != null)
            {
                mascotaEncontrado.Nombre = mascota.Nombre;
                mascotaEncontrado.Color = mascota.Color;
                mascotaEncontrado.Especie = mascota.Especie;
                mascotaEncontrado.Raza = mascota.Raza;

                _appContext.SaveChanges();
            }
            return mascotaEncontrado;
        }


        public Mascota GetMascota(int idMascota)
        {
            return _appContext.Mascotas.FirstOrDefault(p => p.Id == idMascota);
        }

    }

}