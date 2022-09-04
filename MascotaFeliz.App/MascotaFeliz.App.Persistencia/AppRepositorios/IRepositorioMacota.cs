using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MascotaFeliz.App.Persistencia
{
   public interface IRepositorioVeterinario
   {
    IEnumerable<Agenda> GetAllAgenda();
        Agenda AddAgenda (Agenda  Agenda);
        Agenda UpdateAgenda (Agenda  Agenda);
        void DeleteAgenda(int IdAgenda);
        Agenda GetAgenda (int IdAgenda);
   }
        
        
    public interface IRepositorioCliente
   {
    IEnumerable<Cliente> GetAllCliente();
        Cliente AddCliente (Cliente  Cliente);
        Cliente UpdateCliente (Cliente  Cliente);
        void DeleteCliente (int IdCliente);
        Cliente GetCliente (int IdCliente);
   }    
        
        
     public interface IRepositorioHistoriaClinica
   {
    IEnumerable<HistoriaClinica> GetAllHistoriaClinica();
        HistoriaClinica AddHistoriaClinica (HistoriaClinica  HistoriaClinica);
        HistoriaClinica UpdateHistoriaClinica (HistoriaClinica HistoriaClinica);
        void DeleteHistoriaClinica (int IdHistoriaClinica);
        HistoriaClinica GetHistoriaClinica (int IdHistoriaClinica);
   }    
        
        
     public interface IRepositorioMascota
   {
    IEnumerable<Mascota> GetAllMascota();
        Mascota AddMascota (Mascota  Mascota);
        Mascota UpdateMascota (Mascota Mascota);
        void DeleteMascota (int IdMascota);
        Mascota GetMascota (int IdMascota);
        
   }  
        
        
     public interface IRepositorioMedioDePago
   {
    IEnumerable<MedioDePago> GetAllMedioDePago();
        MedioDePago AddMedioDePago (MedioDePago  MedioDePago);
        MedioDePago UpdateMedioDePago (MedioDePago  MedioDePago);
        void DeleteMedioDePago (int IdMedioDePago);
        MedioDePago GetMedioDePago (int IdMedioDePago);     
   }    
        
        
     public interface IRepositorioPersona
   {
    IEnumerable<Persona> GetAllPersona();
        Persona AddPersona (Persona  Persona);
        Persona UpdatePersona (Persona  Persona);
        void DeletePersona (int IdPersona);
        Persona GetPersona (int IdPersona);        
   }    
        
     public interface IRepositorioRol      //<No se tiene todavia atributos en la clase//>
   {
    IEnumerable<Rol> GetAllRol();
        Rol AddRol (Rol Rol);
        Rol UpdateRol (Rol Rol);
        void DeleteRol (int IdRol);
        Rol GetRol (int IdRol);
        
   }    
        
     public interface IRepositorioUsuario     //<No se tiene todavia atributos en la clase//>
   {
    IEnumerable<Usuario> GetAllUsuario();
        Usuario AddUsuario (Usuario  Usuario);
        Usuario UpdateUsuario (Usuario  Usuario);
        void DeleteUsuario (int IdUsuario);
        Usuario GetUsuario (int IdUsuario);
        
   }    
        
     public interface IRepositorioVacuna    
   {
    IEnumerable<Vacuna> GetAllVacuna();
        Vacuna AddVacuna (Vacuna  Vacuna);
        Vacuna UpdateVacuna (Vacuna  Vacuna);
        void DeleteVacuna (int IdVacuna);
        Vacuna GetVacuna (int IdVacuna);
        
        
   }  
       
     public interface IRepositorioVeterinario   
   {
    IEnumerable<Veterinario> GetAllVeterinario();
        Veterinario AddVeterinario (Veterinario   Veterinario);
        Veterinario UpdateVeterinario  (Veterinario  Veterinario);
        void DeleteVeterinario  (int IdVeterinario );
        Veterinario  GetVeterinario  (int IdVeterinario );  
   }   
        
        
      public interface IRepositorioVisitaDomiciliaria  
   {
    IEnumerable<VisitaDomiciliaria> GetAllVisitaDomiciliaria  ();
        VisitaDomiciliaria  AddVisitaDomiciliaria  (VisitaDomiciliaria   VisitaDomiciliaria);
        VisitaDomiciliaria  UpdateVisitaDomiciliaria  (VisitaDomiciliaria  VisitaDomiciliaria);
        void DeleteVisitaDomiciliaria  (int IdVisitaDomiciliaria);
        VisitaDomiciliaria GetVisitaDomiciliaria  (int IdVisitaDomiciliaria);  
   }
}
