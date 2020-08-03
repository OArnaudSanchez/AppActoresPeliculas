using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Peliculas
    {
        //Propiedades
        private int _iD;
        public int ID { get => _iD; set => _iD = value; }

        private string _titulo;
        public string Titulo { get => _titulo; set => _titulo = value; }

        private int _generoID;
        public int GeneroID { get => _generoID; set => _generoID = value; }

        private DateTime _fechaEstreno;
        public DateTime FechaEstreno { get => _fechaEstreno; set => _fechaEstreno = value; }

        private byte[] _foto;
        public byte[] Foto { get => _foto; set => _foto = value; }


        //Constructor vacio
        public Peliculas(){}

        //Constructor con parametros
        public Peliculas(int ID, string Titulo, int idGenero, DateTime fecha, byte[] Foto)
        {
            this.ID = ID;
            this.Titulo = Titulo;
            this.GeneroID = idGenero;
            this.FechaEstreno = fecha;
            this.Foto = Foto;
        }

        SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion);
        SqlCommand comando;

        //Metodos de acceso a datos
        /*
         Por resumir: En cada metodo lo que se hace es llamar de forma asincrona, 
         a cada procedimiento almacenado pasandole sus parametros. Luego si la conexion a la base de datos se encuentra
         abierta, la cerramos

             */
        public async Task<string> RegistrarPelicula(Peliculas peli)
        {
            string resultado = "";

            try
            {
                await conexion.OpenAsync();

                comando = new SqlCommand("RegistrarPelicula", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@titulo", peli._titulo);
                comando.Parameters.AddWithValue("@idGenero", peli._generoID);
                comando.Parameters.AddWithValue("@estreno", peli._fechaEstreno);
                comando.Parameters.AddWithValue("@foto", peli._foto);

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

        public async Task<string> ModificarPelicula(Peliculas peli)
        {
            string resultado = "";

            try
            {
                
                await conexion.OpenAsync();

                comando = new SqlCommand("ModificarPelicula", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", peli._iD);
                comando.Parameters.AddWithValue("@titulo", peli._titulo);
                comando.Parameters.AddWithValue("@idGenero", peli._generoID);
                comando.Parameters.AddWithValue("@estreno", peli._fechaEstreno);
                comando.Parameters.AddWithValue("@foto", peli._foto);



                await comando.ExecuteNonQueryAsync();

                resultado = "Correcto";
            }
            catch (Exception e)
            {
                resultado = "Error";
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

        public async Task<string> EliminarPelicula(Peliculas peli)
        {
            try
            {
                await conexion.OpenAsync();
                comando = new SqlCommand("ModificarActor", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", peli._iD);

                await comando.ExecuteNonQueryAsync();
            }
            catch (Exception)
            {
                return "Error";
            }
            finally
            {
                conexion.Close();
            }
            return "";
        }

        public async Task<DataTable> MostrarDatosPeliculas()
        {

            try
            {
                await conexion.OpenAsync();
                comando = new SqlCommand("MostrarPeliculas", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                 await comando.ExecuteNonQueryAsync();

                SqlDataAdapter adaptadorDatos = new SqlDataAdapter(comando);

                DataTable tabla = new DataTable();
                adaptadorDatos.Fill(tabla);

                return tabla;
            }
            catch (Exception)
            {
               throw new Exception("Ha ocurrido un error al cargar los datos de la base de datos");
            }
            finally
            {
                conexion.Close();
            }
        }

        public async Task<DataTable> Busquedas(string buscar)
        {
            try
            {
                await conexion.OpenAsync();
                comando = new SqlCommand("BusquedasGenerales", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@busqueda", buscar);

                await comando.ExecuteNonQueryAsync();

                SqlDataAdapter adaptadorDatos = new SqlDataAdapter(comando);

                DataTable tabla = new DataTable();
                adaptadorDatos.Fill(tabla);

                return tabla;
            }
            catch (Exception)
            {
                throw new Exception("Ha ocurrido un error al cargar los datos de la base de datos");
            }
            finally
            {
                conexion.Close();
            }
        }

        public async Task<DataTable> DetallesAvanzadosPeliculas(string titulo)
        {
            try
            {
                await conexion.OpenAsync();
                comando = new SqlCommand("DetallesAvanzadosPeliculas", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@tituloPelicula", titulo);

                await comando.ExecuteNonQueryAsync();

                SqlDataAdapter adaptadorDatos = new SqlDataAdapter(comando);

                DataTable tabla = new DataTable();
                adaptadorDatos.Fill(tabla);

                return tabla;
            }
            catch (Exception)
            {
                throw new Exception("Ha ocurrido un error al cargar los datos de la base de datos");
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
