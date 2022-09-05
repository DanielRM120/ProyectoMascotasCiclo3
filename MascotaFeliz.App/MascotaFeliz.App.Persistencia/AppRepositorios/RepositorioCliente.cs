using System;
using System.Collections.Generic;
using MascotaFeliz.App.Dominio;
using System.Linq;


namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioCliente : IRepositorioCliente

    {
       private readonly AppContext _appContext;


        public RepositorioCliente(AppContext appContext)
        {
            _appContext = appContext;
        }


        public Cliente AddCliente(Cliente Cliente)
        {
            var ClienteAdicionado = _appContext.Clientes.Add(Cliente);
            _appContext.SaveChanges();
            return ClienteAdicionado.Entity;
        }


        public void DeleteCliente(int idCliente)
        {
            var ClienteEncontrado = _appContext.Clientes.FirstOrDefault(p => p.Id == idCliente);
            if (ClienteEncontrado == null)
                return;
            _appContext.Clientes.Remove(ClienteEncontrado);
            _appContext.SaveChanges();
        }


        public IEnumerable<Cliente> GetAllCliente()
        {
            return _appContext.Clientes;
        }

        public Cliente UpdateCliente(Cliente Cliente)
        {
            var ClienteEncontrado = _appContext.Clientes.FirstOrDefault(p => p.Id == Cliente.Id);
            if (ClienteEncontrado != null)
            {   
                ClienteEncontrado.Nombres = Cliente.Nombres;
                ClienteEncontrado.Apellidos = Cliente.Apellidos;
                ClienteEncontrado.NumeroTelefono = Cliente.NumeroTelefono;
                ClienteEncontrado.Direccion = Cliente.Direccion;
                ClienteEncontrado.Correo = Cliente.Correo;
                ClienteEncontrado.MedioDePago = Cliente.MedioDePago;
                ClienteEncontrado.Mascota = Cliente.Mascota;
                _appContext.SaveChanges();
            }
            return ClienteEncontrado;
        }

        public Cliente GetCliente(int idCliente)
        {
            return _appContext.Clientes.FirstOrDefault(p => p.Id == idCliente);
        }
    }
}