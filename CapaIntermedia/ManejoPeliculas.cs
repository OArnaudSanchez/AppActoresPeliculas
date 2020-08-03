using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaIntermedia
{
    public class ManejoPeliculas
    {
        /*
         Esta clase es la que conecta nuestros formularios de Peliculas y la logica de acceso a la base de datos.

            Basicamente lo que hice en cada metodo fue, recibir los valores que se van a almacenar en la base de datos,
            asignarle ese valor a las propiedades del objeto y llamar el metodo correspondiente.
        */
        public static async Task<string> NuevaPelicula(string titulo, int idGenero, DateTime fecha, byte[] foto)
        {
            Peliculas peli = new Peliculas();

            try
            {
                peli.Titulo = titulo;
                peli.GeneroID = idGenero;
                peli.FechaEstreno = fecha;
                peli.Foto = foto;
            }
            catch (Exception)
            {

                throw;
            }
            return await peli.RegistrarPelicula(peli);
        }

        public static async Task<string> EditarPelicula(int id, string titulo, int idGenero, DateTime fecha, byte[] foto)
        {
            Peliculas peli = new Peliculas();

            try
            {
                peli.ID = id;
                peli.Titulo = titulo;
                peli.GeneroID = idGenero;
                peli.FechaEstreno = fecha;
                peli.Foto = foto;
            }
            catch (Exception)
            {

                throw;
            }
           

            return await peli.ModificarPelicula(peli);
        }

        public static async Task<string> EliminarPelicula(int id)
        {
            Peliculas peli = new Peliculas();

            try
            {
                peli.ID = id; 
            }
            catch (Exception)
            {

                throw;
            }
            
           return await peli.EliminarPelicula(peli);
        }

        public static async Task<DataTable> MostrarPeliculas()
        {
            Peliculas peli = new Peliculas();
            try
            {
               return await peli.MostrarDatosPeliculas();
            }
            catch (Exception)
            {
                throw new Exception("Ha ocurrido un error");
            }
        }

        //Estos metodos son para buscar, pueden soportar cualquier tipo de busqueda, aunque hay algunas busquedas
        //Que debemos tener al menos un actor relacionado con su pelicula correspondiente para que pueda funcionar.
        public static async Task<DataTable> ResultadosBusquedas(string busqueda)
        {
            try
            {
                Peliculas peli = new Peliculas();
                return await peli.Busquedas(busqueda);
            }
            catch (Exception)
            {
                throw new Exception("Ha ocurrido un error");
            }
        }

        public static async Task<DataTable> DatosAvanzadosPelis(string titulo)
        {
            try
            {
                Peliculas peli = new Peliculas();
                return await peli.DetallesAvanzadosPeliculas(titulo);
            }
            catch (Exception)
            {

                throw new Exception("Ha ocurrido un error");
            }

        }
    }
}
