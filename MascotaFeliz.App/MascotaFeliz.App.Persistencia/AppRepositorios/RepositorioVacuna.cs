using System;
using System.Collections.Generic;
using MascotaFeliz.App.Dominio;
using System.Linq;


namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioVacuna : IRepositorioVacuna

    {
        private readonly AppContext _appContext;


        public RepositorioVacuna(AppContext appContext)
        {
            _appContext = appContext;
        }


        public Vacuna AddVacuna(Vacuna Vacuna)
        {
            var VacunaAdicionado = _appContext.Vacunas.Add(Vacuna);
            _appContext.SaveChanges();
            return VacunaAdicionado.Entity;
        }


        public void DeleteVacuna(int idVacuna)
        {
            var VacunaEncontrado = _appContext.Vacunas.FirstOrDefault(p => p.Id == idVacuna);
            if (VacunaEncontrado == null)
                return;
            _appContext.Vacunas.Remove(VacunaEncontrado);
            _appContext.SaveChanges();
        }


        public IEnumerable<Vacuna> GetAllVacuna()
        {
            return _appContext.Vacunas;
        }

        public Vacuna UpdateVacuna(Vacuna Vacuna)
        {
            var VacunaEncontrado = _appContext.Vacunas.FirstOrDefault(p => p.Id == Vacuna.Id);
            if (VacunaEncontrado != null)
            {   
                VacunaEncontrado.NombreVacuna = Vacuna.NombreVacuna;
                _appContext.SaveChanges();
            }
            return VacunaEncontrado;
        }

        public Vacuna GetVacuna(int idVacuna)
        {
            return _appContext.Vacunas.FirstOrDefault(p => p.Id == idVacuna);
        }
    }
}