using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaIntermedia
{
    public class ManejoActores
    {
        /*
         Esta clase es la que conecta nuestros formularios de Actores y la logica de acceso a la base de datos.

            Basicamente lo que hice en cada metodo fue, recibir los valores que se van a almacenar en la base de datos,
            asignarle ese valor a las propiedades del objeto y llamar el metodo correspondiente.
        */
        public static async Task<string> NuevoActor(string nombre, DateTime fecha, char sexo, byte[] foto)
        {
            
            Actores actor = new Actores
            {
                Nombre = nombre,
                FechaNacimiento = fecha,
                Sexo = sexo,
                Foto = foto
            };
            return await actor.RegistrarActor(actor); 
        }

        public static async Task<string> EditarActor(int id,string nombre, DateTime fecha, char sexo, byte[] foto)
        {
            Actores actor = new Actores
            {
                ID = id,
                Nombre = nombre,
                FechaNacimiento = fecha,
                Sexo = sexo,
                Foto = foto
            };
            
            return await actor.ModificarActor(actor);
        }

        public static async Task<string> EliminarActor(int id)
        {
            Actores actor = new Actores();

            try
            {
                actor.ID = id;
            }
            catch (Exception)
            {
                throw new Exception("Ha Ocurrido un Error");
            }

            return await actor.EliminarActor(actor);
        }

        public static async Task<DataTable> MostrarActores()
        {
            try
            {
                Actores actor = new Actores();
                return await actor.MostrarDatosActores();
            }
            catch (Exception)
            {

                throw new Exception("Ha ocurrido un error");
            }
            
        }

        public static async Task<DataTable> ResultadosBusquedas(string busqueda)
        {
            try
            {
                Actores actor = new Actores();
                return await actor.Busquedas(busqueda);
            }
            catch (Exception)
            {

                throw new Exception("Ha ocurrido un error");
            }

        }

        public static async Task<DataTable> DatosAvanzadosActor(string nombre)
        {
            try
            {
                Actores actor = new Actores();
                return await actor.DetallesAvanzadosActor(nombre);
            }
            catch (Exception)
            {

                throw new Exception("Ha ocurrido un error");
            }

        }
    }
}
