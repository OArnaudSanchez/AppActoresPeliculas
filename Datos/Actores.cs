using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Datos
{
    public class Actores
    {
        //variables
        private int _iD;
        public int ID { get => _iD; set => _iD = value; }

        private string _nombre;
        public string Nombre { get => _nombre; set => _nombre = value; }

        private DateTime _fechaNacimiento;
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }

        private char _sexo;
        public char Sexo { get => _sexo; set => _sexo = value; }

        private byte[] _foto;
        public byte[] Foto { get => _foto; set => _foto = value; }

        //Constructores
        public Actores(){}

        public Actores(int ID, string Nombre, DateTime Fecha, char Sexo, byte[] Foto)
        {
            this.ID = ID;
            this.Nombre = Nombre;
            this.FechaNacimiento = Fecha;
            this.Sexo = Sexo;
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
        public async Task<string> RegistrarActor(Actores actor)
        {
            string resultado = "";

            try
            {
                await conexion.OpenAsync();

                comando = new SqlCommand("RegistrarActor", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombre", actor._nombre);
                comando.Parameters.AddWithValue("@fecha", actor._fechaNacimiento);
                comando.Parameters.AddWithValue("@sexo", actor._sexo);
                comando.Parameters.AddWithValue("@foto", actor._foto);


                await comando.ExecuteNonQueryAsync();

                resultado = "Correcto";
            }
            catch(Exception e)
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

        public async Task<string> ModificarActor(Actores actor)
        {
            string resultado = "";

            try
            {
               await conexion.OpenAsync();

                comando = new SqlCommand("ModificarActor", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", actor._iD);
                comando.Parameters.AddWithValue("@nombre", actor._nombre);
                comando.Parameters.AddWithValue("@fecha", actor._fechaNacimiento);
                comando.Parameters.AddWithValue("@sexo", actor._sexo);
                comando.Parameters.AddWithValue("@foto", actor._foto);

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

        public async Task<string> EliminarActor(Actores actor)
        {
            string resultado = "";
            try
            {
                await conexion.OpenAsync();
                comando = new SqlCommand("EliminarActor", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", actor._iD);

                await comando.ExecuteNonQueryAsync();
                resultado = "Correcto";
            }
            catch 
            {
                resultado =  "Error";
            }
            finally
            {
                conexion.Close();
            }

            return resultado;
        }

        public async Task<DataTable> MostrarDatosActores()
        {
            try
            {
                await conexion.OpenAsync();

                comando = new SqlCommand("MostrarActores", conexion);
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

        public async Task<DataTable> DetallesAvanzadosActor(string nombre)
        {
            try
            {
                await conexion.OpenAsync();
                comando = new SqlCommand("DetallesAvanzadosActor", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombreactor", nombre);

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
