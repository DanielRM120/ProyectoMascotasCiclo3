using System;
using System.Collections.Generic;
using MascotaFeliz.App.Dominio;
using System.Linq;


namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioAgenda : IRepositorioAgenda

    {
        private readonly AppContext _appContext;

        public RepositorioAgenda(AppContext appContext)
        {
            _appContext = appContext;
        }


        public Agenda AddAgenda(Agenda Agenda)
        {
            var AgendaAdicionado = _appContext.Agendas.Add(Agenda);
            _appContext.SaveChanges();
            return AgendaAdicionado.Entity;
        }


        public void DeleteAgenda(int idAgenda)
        {
            var AgendaEncontrado = _appContext.Agendas.FirstOrDefault(p => p.Id == idAgenda);
            if (AgendaEncontrado == null)
                return;
            _appContext.Agendas.Remove(AgendaEncontrado);
            _appContext.SaveChanges();
        }


        public IEnumerable<Agenda> GetAllAgenda()
        {
            return _appContext.Agendas;
        }

        public Agenda UpdateAgenda(Agenda Agenda)
        {
            var AgendaEncontrado = _appContext.Agendas.FirstOrDefault(p => p.Id == Agenda.Id);
            if (AgendaEncontrado != null)
            {   
                AgendaEncontrado.Fecha = Agenda.Fecha;
                AgendaEncontrado.Hora = Agenda.Hora;
                AgendaEncontrado.Reserva = Agenda.Reserva;

                _appContext.SaveChanges();
            }
            return AgendaEncontrado;
        }

        public Agenda GetAgenda(int idAgenda)
        {
            return _appContext.Agendas.FirstOrDefault(p => p.Id == idAgenda);
        }
    }
}