using System;
using System.Collections.Generic;
using MascotaFeliz.App.Dominio;
using System.Linq;
using System.Threading.Tasks;
using RegistroLogin.Helpers;

namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        private readonly AppContext _appContext;

       public RepositorioUsuario(AppContext appContext)
        {
            _appContext = appContext;
        }

       public int GetMaxId()
        {
            if (this._appContext.Usuarios.Count() == 0)
            {
                return 1;
            }
            else
            {
                
                return this._appContext.Usuarios.Max(z => z.Id) + 1;
            }
        }

        public bool ExisteEmail(string email)
        {
            var consulta = from datos in this._appContext.Usuarios
                           where datos.Email == email
                           select datos;
            if(consulta.Count() > 0 )
            {
                //El email existe en la base de datos
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RegistrarUsuario(string email, string password, string nombre, string apellidos, string tipo)
        {
            bool ExisteEmail = this.ExisteEmail(email);
            if (ExisteEmail)
            {
                return false;
            }
            else
            {
                int id = this.GetMaxId();
                Rol usuario1 = new Rol();
                usuario1.Id = id;
                usuario1.Email = email;
                usuario1.Nombre = nombre;
                usuario1.Apellidos = apellidos;
                usuario1.Tipo = tipo;

                //GENERAMOS UN SALT ALEATORIO PARA CADA USUARIO

                usuario1.Salt =HelperCryptography.GenerateSalt();               
    
                //GENERAMOS SU PASSWORD CON EL SALT
                Usuario usuario = new Usuario();
                usuario.Password = HelperCryptography.EncriptarPassword(password, usuario1.Salt);
                this._appContext.Usuarios.Add(usuario1);
                this._appContext.SaveChanges();

                return true;
            }
            
        }

        public Usuario LogInUsuario(string email, string password)
        {
            Usuario usuario = this._appContext.Usuarios.SingleOrDefault(x => x.Email == email);
            if (usuario == null)
            {
                return null;
            }
            else
            {
                //Debemos comparar con la base de datos el password haciendo de nuevo el cifrado con cada salt de usuario
                Rol usuario1 = new Rol();
                byte[] passUsuario = usuario.Password;
                string salt = usuario1.Salt;
                //Ciframos de nuevo para comparar
                byte[] temporal = HelperCryptography.EncriptarPassword(password, salt);

                //Comparamos los arrays para comprobar si el cifrado es el mismo
                bool respuesta = HelperCryptography.compareArrays(passUsuario, temporal);
                if(respuesta == true)
                {
                    return usuario;
                }
                else
                {
                    //Contraseña incorrecta
                    return null;
                }
            }
        }

        public List<Usuario> GetUsuarios()
        {
            var consulta = from datos in this._appContext.Usuarios
                           select datos;
            return consulta.ToList();
        }
    }
    
}