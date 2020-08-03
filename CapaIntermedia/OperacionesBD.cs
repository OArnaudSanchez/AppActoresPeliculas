using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaIntermedia
{
    public class OperacionesBD
    {
        //La funcionalidad basicamente de este metodo y de esta clase como su nombre lo dice, es realizar operaciones en la base de datos.
        //Especialmente consultas, solo tenemos que pasarle el query y nos devuelve el dataset con los datos
        public static DataSet Ejecutar(string codigo)
        {
            //Conexion a bd
            SqlConnection con = new SqlConnection(Conexion.CadenaConexion);

            DataSet data = new DataSet();

            //Adaptar los datos a un formato soportado
            SqlDataAdapter adapter = new SqlDataAdapter(codigo, con);

            //Llenar las tablas o matriz donde se transportaran los datos
            adapter.Fill(data);

            con.Close();

            //retornando el dataset
            return data;
        }
    }
}
