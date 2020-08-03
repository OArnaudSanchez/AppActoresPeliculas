using AppAdminPeliculas.FormActores;
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
    public partial class FormAsignarActoresPeliculas : Form
    {
        public FormAsignarActoresPeliculas()
        {
            InitializeComponent();
        }

        private void bBuscarActor_Click(object sender, EventArgs e)
        {
            //Llamamos la ventana para seleccionar el actor
            EscogerActor escogerActor = new EscogerActor();
            escogerActor.ShowDialog();

            try
            {
                //Traemos los datos del actor que seleccionamos
                int idActor = EscogerActor.ID;
                tNombreActor.Text = EscogerActor.Nombre;
                tFechaActor.Text = EscogerActor.FechaNacimiento.ToString().Substring(0, 10);
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error al cargar los datos, inserte datos e intente de nuevo.");
            }
            
        }

        private void bBuscarPelicula_Click(object sender, EventArgs e)
        {
            //Lo mismo para la pelicula, llamamos la ventana para seleccionar
            EscogerPelicula escogerPelicula = new EscogerPelicula();
            escogerPelicula.ShowDialog();

            try
            {
                //Traemos los datos
                tTituloPelicula.Text = EscogerPelicula.TituloPelicula;
                tEstrenoPelicula.Text = EscogerPelicula.FechaEstreno.ToString().Substring(0, 10);
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error al cargar los datos, inserte datos e intente de nuevo.");
            }
            
        }

        private async void MostrarDatosActoresPeliculas()
        {
            dataActoresPeliculas.DataSource = await ManejoActoresPeliculas.MostrarDatos();
        }

        private async void btnNuevaPelicula_Click(object sender, EventArgs e)
        {   
            try
            {
                ////Hacemos una consulta para saber si el actor ya existe en una pelicula
                //string comando = string.Format($"select a.Nombre, ap.idActor, ap.idPelicula, p.Titulo  from Actores a inner join " +
                //    $"Actores_Peliculas ap on a.ID = ap.idActor" +
                //    $" inner join Peliculas p on ap.idPelicula = p.ID where ap.idPelicula='{EscogerPelicula.ID}'");
                //DataSet data = OperacionesBD.Ejecutar(comando);

                //string opcionAgregar = data.Tables[0].Rows[0]["Titulo"].ToString().Trim();

                //if (opcionAgregar == tTituloPelicula.Text)
                //{
                //    MessageBox.Show("El actor ya esta asgnado a esta pelicula. Pruebe con uno diferente....");
                //    LimpiarCampos();
                //}
                //else
                //{


                //}

                int idActor = EscogerActor.ID;
                int idPelicula = EscogerPelicula.ID;

                //Mandamos los datos para que se procesen en xml
                await ManejoActoresPeliculas.GuardarXMLActorPelicula(idActor, idPelicula);
                MessageBox.Show("El actor fue agregado a la pelicula correctamente");
                this.MostrarDatosActoresPeliculas();
                this.LimpiarCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("NO Campos vacios");
                errorProvider1.SetError(tNombreActor, "Seleccione el actor");
                errorProvider1.SetError(tFechaActor, "Seleccione el actor");
                errorProvider1.SetError(tTituloPelicula, "Seleccione la pelicula");
                errorProvider1.SetError(tEstrenoPelicula, "Seleccione la pelicula");

            }
        }

        private void LimpiarCampos()
        {
            tNombreActor.Clear();
            tFechaActor.Clear();
            tTituloPelicula.Clear();
            tEstrenoPelicula.Clear();
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAsignarActoresPeliculas_Load(object sender, EventArgs e)
        {
            this.MostrarDatosActoresPeliculas();
        }
    }
}
