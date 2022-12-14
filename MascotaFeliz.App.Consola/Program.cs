using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola
{
    class Program
    {
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext()); //"Instancia"
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        private static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
        private static IRepositorioVisitaPyP _repoVisitaPyP = new RepositorioVisitaPyP(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Mascota Feliz");
            /*Métodos requeridos 
            1. Adicionar
            2. Actualizar 
            3. Eliminar 
            4. Buscar 1
            5. Listar todo
            6. Bucar con filtro */

            //Métodos Dueño
            //AddDueno();
            //EliminarDueno(3);

            //Metodos Veterinario 
            //AddVeterinario();
            //Metodos Mascotas 
            //AddMascota();
            //BuscarMascota(1);
            //ListadoMascotas();
            //ActualizarMascota();
            //EliminarMascota(3);
             
            //Metodos Historia 
            //AddHistoria();

            //Metodos Visitas
            //AddVisitaPyP();
        }

        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                Nombres = "Juan",
                Apellidos = "Sin Miedo",
                Direccion = "Bajo un puente",
                Telefono = "1234567891",
                Correo = "juansinmiedo@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }

        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                Nombres = "Maria",
                Apellidos = "Velez",
                Direccion = "Calle 5",
                Telefono = "98765423",
                TarjetaProfesional = "506075"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }

        private static void AddMascota()
        {
            var mascota = new Mascota
            {
                Nombre = "Bobi",
                Color = "Cafe",
                Especie = "Canico",
                Raza = "Bóxer",
                
            };
            _repoMascota.AddMascota(mascota);
        }

        private static void AddHistoria()
        {
            var historia = new Historia
            {
                FechaInicial = new DateTime(2022, 04, 22)

            };
            _repoHistoria.AddHistoria(historia);
        }

        private static void AddVisitaPyP()
        {
            var visitaPyP = new VisitaPyP
            {
                FechaVisita = new DateTime(2022, 11, 20),
                Temperatura = 36f, 
                Peso = 4f,
                FrecuenciaRespiratoria = 55f,
                FrecuenciaCardiaca = 30f,
                EstadoAnimo = "Perezoso",
                IdVeterinario = 2,
                Recomendaciones = "Dormir"
            };
            _repoVisitaPyP.AddVisitaPyP(visitaPyP);
        }
        
        private static void BuscarMascota(int idMascota)
        {
            var mascota = _repoMascota.GetMascota(idMascota);
            Console.WriteLine(mascota.Nombre+" "+mascota.Color+" "+mascota.Especie+" "+mascota.Raza);
        }

        private static void ListadoMascotas()
        {
            var Mascotas = _repoMascota.GetAllMascotas();
                foreach (Mascota i in Mascotas) {
                    Console.WriteLine(i.Nombre+" "+i.Color+" "+i.Especie+" "+i.Raza);
                }
        }

        private static void EliminarMascota(int idMascota)
        {
            _repoMascota.DeleteMascota(idMascota);
            Console.WriteLine("Mascota Eliminada");
        }
        private static void EliminarDueno(int idDueno)
        {
            _repoDueno.DeleteDueno(idDueno);
            Console.WriteLine("Dueño Eliminado");
        }
    }
}
