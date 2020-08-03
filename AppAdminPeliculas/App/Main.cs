using AppAdminPeliculas.FormActores;
using AppAdminPeliculas.FormPeliculas;
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

namespace AppAdminPeliculas.App
{
    /*
     Nota: para realizar las busquedas primero se debera asignar actores a peliculas
         */
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public static string TituloPelicula;
        public static string NombreActor;

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void MostrarDatosActores()
        {
            dataActores.DataSource = await ManejoActores.MostrarActores();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDetallesAvanzadoActor_Click(object sender, EventArgs e)
        {
            //Mostrar los detalles avanzados
            FormDetallesAvanzadosActor avanzadosActor = new FormDetallesAvanzadosActor();
            avanzadosActor.ShowDialog();
        }

        private void btnNuevoActor_Click(object sender, EventArgs e)
        {
            AgregarActor nuevoActor = new AgregarActor();
            nuevoActor.ShowDialog();
        }

        private void btnModificarActor_Click(object sender, EventArgs e)
        {
            ModificarActor modificarActor = new ModificarActor();
            modificarActor.ShowDialog();
        }

        private async void tBusquedaActor_TextChanged(object sender, EventArgs e)
        {
            if (tBusquedaActor.Text.Length > 0)
            {
                dataActores.DataSource = await ManejoActores.ResultadosBusquedas(tBusquedaActor.Text);
            }
            else
            {
                this.MostrarDatosActores();
            }
        }

        private async void comboBox1_TextChanged(object sender, EventArgs e)
        {
            int indiceComboBox = comboBox1.SelectedIndex;

            if (indiceComboBox > -1)
            {
                if (comboBox1.GetItemText(comboBox1.Items[indiceComboBox]) == "Masculino")
                {
                    dataActores.DataSource = await ManejoActores.ResultadosBusquedas("M");
                }
                else
                {
                    dataActores.DataSource = await ManejoActores.ResultadosBusquedas("F");
                }
            }
            else
            {
                this.MostrarDatosActores();
            }
        }

        private void dataActores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = dataActores.CurrentRow.Index;

            try
            {
                NombreActor = dataActores[1, posicion].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error mientras se seleccionaba el actor. Intente de nuevo");
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

            this.MostrarDatosActores();
            this.MostrarDatosPeliculas();

            if (dataActores.Rows.Count > 0)
            {
                //Activamos el boton de mostrar detalles avanzados del actor
                btnDetallesAvanzadoActor.Enabled = true;
            }

            if (dataPeliculas.Rows.Count > 0)
            {
                //Activamos el boton de mostrar detalles avanzados de las peliculas
                btnDetallesAvanzadosPeliculas.Enabled = true;
            }
        }


        private async void MostrarDatosPeliculas()
        {
            dataPeliculas.DataSource = await ManejoPeliculas.MostrarPeliculas();
        }

        private void btnDetallesAvanzadosPeliculas_Click(object sender, EventArgs e)
        {
            //Mostrar detalles Avanzados
            FormDetallesAvanzadosPelicula avanzadosPelicula = new FormDetallesAvanzadosPelicula();
            avanzadosPelicula.ShowDialog();
        }

        private void btnNuevaPelicula_Click(object sender, EventArgs e)
        {
            //Agregar Nueva Pelicula
            AgregarPelicula nuevaPelicula = new AgregarPelicula();
            nuevaPelicula.ShowDialog();
        }

        private void btnModificarPelicula_Click(object sender, EventArgs e)
        {
            //Modificar Una Pelicula
            ModificarPelicula modificarPelicula = new ModificarPelicula();
            modificarPelicula.ShowDialog();
        }

        private void bAsignarActoresPeliculas_Click(object sender, EventArgs e)
        {
            FormAsignarActoresPeliculas actoresPeliculas = new FormAsignarActoresPeliculas();
            actoresPeliculas.ShowDialog();
        }

        private async void tBusquedaPelicula_TextChanged(object sender, EventArgs e)
        {
            if (tBusquedaPelicula.Text.Length > 0)
            {
                dataPeliculas.DataSource = await ManejoPeliculas.ResultadosBusquedas(tBusquedaPelicula.Text);
            }
            else
            {
                this.MostrarDatosPeliculas();
            }
        }

        private async void cGeneroPelicula_TextChanged(object sender, EventArgs e)
        {
            int indiceComboBox = cGeneroPelicula.SelectedIndex;


            if (indiceComboBox > -1)
            {
                string GeneroSeleccionado = cGeneroPelicula.GetItemText(cGeneroPelicula.Items[indiceComboBox]);
                dataPeliculas.DataSource = await ManejoPeliculas.ResultadosBusquedas(GeneroSeleccionado);
            }
            else
            {
                this.MostrarDatosPeliculas();
            }
        }

        private void dataPeliculas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = dataPeliculas.CurrentRow.Index;

            try
            {
                TituloPelicula = dataPeliculas[1, posicion].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error mientras se seleccionaba el actor. Intente de nuevo");
            }
        }

        private void dataActores_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(dataActores, "Seleccione la fila del actor que desea ver sus detalles avanzados");
        }

        private void tabPage1_MouseHover(object sender, EventArgs e)
        {
            this.MostrarDatosActores();
        }

        private void tabControl1_MouseHover(object sender, EventArgs e)
        {
            this.MostrarDatosPeliculas();
        }
    }
}
