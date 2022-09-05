using System;
using System.Collections.Generic;
using MascotaFeliz.App.Dominio;
using System.Linq;


namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioVisitaDomiciliaria : IRepositorioVisitaDomiciliaria
    {
        private readonly AppContext _appContext;


        public RepositorioVisitaDomiciliaria(AppContext appContext)
        {
            _appContext = appContext;
        }

        public IEnumerable<VisitaDomiciliaria> GetAllVisitaDomiciliaria()
        {
            return _appContext.VisitasDomiciliarias;
        }

        public VisitaDomiciliaria AddVisitaDomiciliaria(VisitaDomiciliaria VisitaDomiciliaria)
        {
            var VisitaDomiciliariaAdicionado = _appContext.VisitasDomiciliarias.Add(VisitaDomiciliaria);
            _appContext.SaveChanges();
            return VisitaDomiciliariaAdicionado.Entity;
        }

        public VisitaDomiciliaria UpdateVisitaDomiciliaria(VisitaDomiciliaria VisitaDomiciliaria)
        {
            var VisitaDomiciliariaEncontrado = _appContext.VisitasDomiciliarias.FirstOrDefault(p => p.Id == VisitaDomiciliaria.Id);
            if (VisitaDomiciliariaEncontrado != null)
            {
                VisitaDomiciliariaEncontrado.Temperatura = VisitaDomiciliaria.Temperatura;
                VisitaDomiciliariaEncontrado.Peso = VisitaDomiciliaria.Peso;
                VisitaDomiciliariaEncontrado.FrecuenciaRespiratoria = VisitaDomiciliaria.FrecuenciaRespiratoria;
                VisitaDomiciliariaEncontrado.FrecuenciaCardiaca = VisitaDomiciliaria.FrecuenciaCardiaca;
                VisitaDomiciliariaEncontrado.EstadoAnimo = VisitaDomiciliaria.EstadoAnimo;
                VisitaDomiciliariaEncontrado.Recomendaciones = VisitaDomiciliaria.Recomendaciones;
                _appContext.SaveChanges();
            }
            return VisitaDomiciliariaEncontrado;
        }

        public void DeleteVisitaDomiciliaria(int idVisitaDomiciliaria)
        {
            var VisitaDomiciliariaEncontrado = _appContext.VisitasDomiciliarias.FirstOrDefault(p => p.Id == idVisitaDomiciliaria);
            if (VisitaDomiciliariaEncontrado == null)
                return;
            _appContext.VisitasDomiciliarias.Remove(VisitaDomiciliariaEncontrado);
            _appContext.SaveChanges();
        }

        public VisitaDomiciliaria GetVisitaDomiciliaria(int idVisitaDomiciliaria)
        {
            return _appContext.VisitasDomiciliarias.FirstOrDefault(p => p.Id == idVisitaDomiciliaria);
        }
    }
}