using AppAdminPeliculas.App;
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
    public partial class FormDetallesAvanzadosPelicula : Form
    {
        public FormDetallesAvanzadosPelicula()
        {
            InitializeComponent();
        }

        private async void FormDetallesAvanzadosPelicula_Load(object sender, EventArgs e)
        {
            try
            {
                //Traemos el detalle avanzado del titulo de la pelicula que se selecciono en el form Principal
                dataPeliculas.DataSource = await ManejoPeliculas.DatosAvanzadosPelis(Main.TituloPelicula);
            }
            catch (Exception)
            {

                MessageBox.Show("NO hay datos para cargar. Debe Asignar los actores a las peliculas para poder visualizar esta parte...");
            }
            
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
