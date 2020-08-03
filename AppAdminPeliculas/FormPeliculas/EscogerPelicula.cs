using CapaIntermedia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAdminPeliculas.FormPeliculas
{
    public partial class EscogerPelicula : Form
    {
        public EscogerPelicula()
        {
            InitializeComponent();
        }

        //Variables que usaremos para almacenar los valores del cliente que se seleccione.
        //Para la seleccion solo hay que darle click a la fila que queremos seleccionar
        public static int ID;
        public static string TituloPelicula;
        public static string FechaEstreno;


        private async void EscogerPelicula_Load(object sender, EventArgs e)
        {
            dataPeliculas.DataSource = await ManejoPeliculas.MostrarPeliculas();
        }

        private void dataPeliculas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Activamos un evento cuando se haga click en una de las celdas
            try
            {
                int posicion;
                posicion = dataPeliculas.CurrentRow.Index;

                if (MessageBox.Show("Desea Seleccionar Esta pelicula??", "Informacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    //Almacenamos los valores que se seleccionaron en la celda, para luego utilizarlo fuera de esta clase.
                    ID = int.Parse(dataPeliculas[0, posicion].Value.ToString());
                    TituloPelicula = dataPeliculas[1, posicion].Value.ToString();
                    FechaEstreno = dataPeliculas[3, posicion].Value.ToString();

                    MessageBox.Show("Pelicula seleccionada correctamente. Se cerrara la ventana para proceder", "Informacion");
                    this.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error al cargar los datos, inserte datos e intente de nuevo.");
            }
            
                
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
