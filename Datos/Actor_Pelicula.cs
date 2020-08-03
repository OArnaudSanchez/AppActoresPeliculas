using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    //El proposito de esta clase, es en pocas palabras para unir las peliculas con los actores que esten almacenados en la bd
    public class Actor_Pelicula
    {
        //Variables
        private int _id;
        public int ID { get => _id; set => _id = value; }

        private int _idActor;
        public int idActor { get => _idActor; set => _idActor = value; }

        private int _idPelicula;
        public int idPelicula { get => _idPelicula; set => _idPelicula = value; }



        public Actor_Pelicula() { }

        public Actor_Pelicula(int id,int idActor, int idPelicula)
        {
            this._id = id;
            this.idActor = idActor;
            this.idPelicula = idPelicula;
        }

        SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion);
        SqlCommand comando;

       
        public async Task<string> EnviarXMLBD(Actor_Pelicula actor_Pelicula)
        {
            /*La Logica dentro de este metodo es un poco distinta a los demas, ya que estamos enviando los datos mediante
            xml a la base de datos*/
            string resultado = "";

            try
            {
                await conexion.OpenAsync();

                //Creamos el xml, con los datos recibidos
                string consruccionXML = $"<?xml version='1.0' standalone='yes'?>" +
                                        $"<data>" +
                                            $"<misDatos>" +
                                                $"<idActor>{actor_Pelicula._idActor}</idActor>" +
                                                $"<idPelicula>{actor_Pelicula._idPelicula}</idPelicula>" +
                                            $"</misDatos>" +
                                        $"</data>";

                comando = new SqlCommand("InsertarXMLDB", conexion);//Llamamos el procedimiento
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@xml", consruccionXML);//Enviamos el xml a el procedimiento para que lo ejecute

                await comando.ExecuteNonQueryAsync();

                resultado = "Correcto";
            }
            catch (Exception e)
            {
                resultado = e.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }


            return resultado;
        }

        public async Task<string> ModificarActorPelicula(Actor_Pelicula actor_Pelicula)
        {
            string resultado = "";
            try
            {
                await conexion.OpenAsync();
                comando = new SqlCommand("ModificarActoresPeliculas", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", actor_Pelicula._id);
                comando.Parameters.AddWithValue("@idActor", actor_Pelicula._idActor);
                comando.Parameters.AddWithValue("@idPelicula", actor_Pelicula._idPelicula);


                await comando.ExecuteNonQueryAsync();

                resultado = "Corecto";
            }
            catch (Exception)
            {

                resultado = "Error";
            }
            finally
            {
                conexion.Close();
            }
            return resultado;
        }

        /*Este metodo funciona pero no lo implemente en ninguno de los formularios, ya que no me lo pedia en el pdf de
        los requerimientos. */
        public async Task<string> EliminarActorPelicula(Actor_Pelicula actor_Pelicula)
        {
            string resultado = "";
            try
            {
                await conexion.OpenAsync();
                comando = new SqlCommand("EliminarActoresPeliculas", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", actor_Pelicula._id);

                await comando.ExecuteNonQueryAsync();

                resultado = "Correcto";
            }
            catch (Exception)
            {

                resultado = "Error";
            }
            finally
            {
                conexion.Close();
            }
            return resultado;
        }

        public async Task<DataTable> MostrarDatosActoresPeliculas()
        {
            try
            {
                await conexion.OpenAsync();

                comando = new SqlCommand("MostrarDatosActoresPeliculas", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                await comando.ExecuteNonQueryAsync();

                SqlDataAdapter adaptadorDeDatos = new SqlDataAdapter(comando);

                DataTable tabla = new DataTable();

                adaptadorDeDatos.Fill(tabla);

                return tabla;
            }
            catch (Exception)
            {
                throw new Exception("Ha ocurrido un error al mostrar los datos desde la base de datos: ");
            }
            finally
            {
                conexion.Close();
            }

        }
    }
}
