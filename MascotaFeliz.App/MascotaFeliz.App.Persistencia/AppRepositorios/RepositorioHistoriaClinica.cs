using System;
using System.Collections.Generic;
using MascotaFeliz.App.Dominio;
using System.Linq;


namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioHistoriaClinica : IRepositorioHistoriaClinica

    {
       private readonly AppContext _appContext;


        public RepositorioHistoriaClinica(AppContext appContext)
        {
            _appContext = appContext;
        }


        public HistoriaClinica AddHistoriaClinica(HistoriaClinica HistoriaClinica)
        {
            var HistoriaClinicaAdicionado = _appContext.HistoriasClinicas.Add(HistoriaClinica);
            _appContext.SaveChanges();
            return HistoriaClinicaAdicionado.Entity;
        }


        public void DeleteHistoriaClinica(int idHistoriaClinica)
        {
            var HistoriaClinicaEncontrado = _appContext.HistoriasClinicas.FirstOrDefault(p => p.Id == idHistoriaClinica);
            if (HistoriaClinicaEncontrado == null)
                return;
            _appContext.HistoriasClinicas.Remove(HistoriaClinicaEncontrado);
            _appContext.SaveChanges();
        }


        public IEnumerable<HistoriaClinica> GetAllHistoriaClinica()
        {
            return _appContext.HistoriasClinicas;
        }

        public HistoriaClinica UpdateHistoriaClinica(HistoriaClinica HistoriaClinica)
        {
            var HistoriaClinicaEncontrado = _appContext.HistoriasClinicas.FirstOrDefault(H => H.Id == HistoriaClinica.Id);
            if (HistoriaClinicaEncontrado != null)
            {   
                HistoriaClinicaEncontrado.Cliente = HistoriaClinica.Cliente;
                HistoriaClinicaEncontrado.Mascota = HistoriaClinica.Mascota;
                _appContext.SaveChanges();
            }
            return HistoriaClinicaEncontrado;
        }

        public HistoriaClinica GetHistoriaClinica(int idHistoriaClinica)
        {
            return _appContext.HistoriasClinicas.FirstOrDefault(p => p.Id == idHistoriaClinica);
        }
    }
}