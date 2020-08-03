using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaIntermedia
{
    public class ManejoActoresPeliculas
    {
        /*
         Esta clase es la que nos ayuda a hacer una interconexion para almacenar los datos relacionados.

            Basicamente lo que hice en cada metodo fue, recibir los valores que se van a almacenar en la base de datos,
            asignarle ese valor a las propiedades del objeto y llamar el metodo correspondiente.
        */
        public static async Task<string> GuardarXMLActorPelicula(int idActor, int idPelicula)
        {//Recibimos los parametros para el xml
            Actor_Pelicula actor_Pelicula = new Actor_Pelicula();

            try
            {
                actor_Pelicula.idActor = idActor;
                actor_Pelicula.idPelicula = idPelicula;
            }
            catch (Exception)
            {

                throw new Exception("Ocurrio un problema");
            }

            return await actor_Pelicula.EnviarXMLBD(actor_Pelicula);
        }

        public static async Task<string> EditarActorPelicula(int id, int idActor, int idPelicula)
        {
            Actor_Pelicula actor_Pelicula = new Actor_Pelicula();

            try
            {
                actor_Pelicula.ID = id;
                actor_Pelicula.idActor = idActor;
                actor_Pelicula.idPelicula = idPelicula;
            }
            catch (Exception)
            {

                throw new Exception("Ocurrio un problema");
            }

            return await actor_Pelicula.ModificarActorPelicula(actor_Pelicula);
        }


        public static async Task<string> EliminarActorPelicula(int id)
        {
            Actor_Pelicula actor_Pelicula = new Actor_Pelicula();

            try
            {
                actor_Pelicula.ID = id;
            }
            catch (Exception)
            {
                throw new Exception("Ocurrio un problema");
            }

           return await actor_Pelicula.EliminarActorPelicula(actor_Pelicula);
        }

        public static async Task<DataTable> MostrarDatos()
        {
            try
            {
                Actor_Pelicula actor_Pelicula = new Actor_Pelicula();
                return await actor_Pelicula.MostrarDatosActoresPeliculas();
            }
            catch (Exception)
            {
                throw new Exception("Ocurrio un problema");
            }

            
        }
    }
}
