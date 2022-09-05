using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;


namespace MascotaFeliz.App.Consola
{
    class Program
    {
        public static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            AddMascota();
        }

        private static void AddMascota()
        {
            var mascota = new Mascota
            {
                Nombre = "Rex",
                Color = "Negro con Amarillo",
                Especie = "Perro",
                Raza = "Pastor Aleman"
            };
            _repoMascota.AddMascota(mascota);
        }
    }
}
