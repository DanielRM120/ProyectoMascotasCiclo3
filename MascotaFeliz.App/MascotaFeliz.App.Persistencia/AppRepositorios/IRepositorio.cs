using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioAgenda
    {
        IEnumerable<Agenda> GetAllAgenda();
        Agenda AddAgenda(Agenda Agenda);
        Agenda UpdateAgenda(Agenda Agenda);
        void DeleteAgenda(int idAgenda);
        Agenda GetAgenda(int idAgenda);
    }


    public interface IRepositorioCliente
    {
        IEnumerable<Cliente> GetAllCliente();
        Cliente AddCliente(Cliente Cliente);
        Cliente UpdateCliente(Cliente Cliente);
        void DeleteCliente(int idCliente);
        Cliente GetCliente(int idCliente);
    }


    public interface IRepositorioHistoriaClinica
    {
        IEnumerable<HistoriaClinica> GetAllHistoriaClinica();
        HistoriaClinica AddHistoriaClinica(HistoriaClinica HistoriaClinica);
        HistoriaClinica UpdateHistoriaClinica(HistoriaClinica HistoriaClinica);
        void DeleteHistoriaClinica(int idHistoriaClinica);
        HistoriaClinica GetHistoriaClinica(int idHistoriaClinica);
    }


    public interface IRepositorioMascota
    {
        IEnumerable<Mascota> GetAllMascota();
        Mascota AddMascota(Mascota Mascota);
        Mascota UpdateMascota(Mascota Mascota);
        void DeleteMascota(int idMascota);
        Mascota GetMascota(int idMascota);

    }


    public interface IRepositorioMedioDePago
    {

        IEnumerable<MedioDePago> GetAllMedioDePago();
        MedioDePago AddMedioDePago(MedioDePago MedioDePago);
        MedioDePago UpdateMedioDePago(MedioDePago MedioDePago);
        void DeleteMedioDePago(int idMedioDePago);
        MedioDePago GetMedioDePago(int idMedioDePago);
    }


    public interface IRepositorioPersona
    {
        IEnumerable<Persona> GetAllPersona();
        Persona AddPersona(Persona Persona);
        Persona UpdatePersona(Persona Persona);
        void DeletePersona(int idPersona);
        Persona GetPersona(int idPersona);
    }

    public interface IRepositorioRol      //<No se tiene todavia atributos en la clase//>
    {
        IEnumerable<Rol> GetAllRol();
        Rol AddRol(Rol Rol);
        Rol UpdateRol(Rol Rol);
        void DeleteRol(int idRol);
        Rol GetRol(int idRol);

    }

    public interface IRepositorioUsuario     //<No se tiene todavia atributos en la clase//>
    {
        IEnumerable<Usuario> GetAllUsuario();
        Usuario AddUsuario(Usuario Usuario);
        Usuario UpdateUsuario(Usuario Usuario);
        void DeleteUsuario(int idUsuario);
        Usuario GetUsuario(int idUsuario);

    }

    public interface IRepositorioVacuna
    {
        IEnumerable<Vacuna> GetAllVacuna();
        Vacuna AddVacuna(Vacuna Vacuna);
        Vacuna UpdateVacuna(Vacuna Vacuna);
        void DeleteVacuna(int idVacuna);
        Vacuna GetVacuna(int idVacuna);


    }


    public interface IRepositorioVeterinario
    {
        IEnumerable<Veterinario> GetAllVeterinario();
        Veterinario AddVeterinario(Veterinario Veterinario);
        Veterinario UpdateVeterinario(Veterinario Veterinario);
        void DeleteVeterinario(int idVeterinario);
        Veterinario GetVeterinario(int idVeterinario);
    }


    public interface IRepositorioVisitaDomiciliaria
    {
        IEnumerable<VisitaDomiciliaria> GetAllVisitaDomiciliaria();
        VisitaDomiciliaria AddVisitaDomiciliaria(VisitaDomiciliaria VisitaDomiciliaria);
        VisitaDomiciliaria UpdateVisitaDomiciliaria(VisitaDomiciliaria VisitaDomiciliaria);
        void DeleteVisitaDomiciliaria(int idVisitaDomiciliaria);
        VisitaDomiciliaria GetVisitaDomiciliaria(int idVisitaDomiciliaria);
    }
}
