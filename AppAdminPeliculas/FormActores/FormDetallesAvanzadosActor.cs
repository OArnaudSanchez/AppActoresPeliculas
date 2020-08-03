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

namespace AppAdminPeliculas.FormActores
{
    public partial class FormDetallesAvanzadosActor : Form
    {
        public FormDetallesAvanzadosActor()
        {
            InitializeComponent();
        }

        private async void FormDetallesAvanzadosActor_Load(object sender, EventArgs e)
        {
            try
            {
                //mostramos los datos avanzados, del usuario seleccionado
                dataActores.DataSource = await ManejoActores.DatosAvanzadosActor(Main.NombreActor);
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
