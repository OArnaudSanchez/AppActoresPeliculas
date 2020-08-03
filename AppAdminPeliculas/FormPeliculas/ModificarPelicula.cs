using CapaIntermedia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAdminPeliculas.FormPeliculas
{
    public partial class ModificarPelicula : Form
    {
        public object ComponenteImagen { get; private set; }

        public ModificarPelicula()
        {
            InitializeComponent();
        }
        private async void MostrarDatosPeliculas()
        {
            dataPeliculas.DataSource = await ManejoPeliculas.MostrarPeliculas();
        }

        private void ModificarPelicula_Load(object sender, EventArgs e)
        {
            this.MostrarDatosPeliculas();
        }

        private void btnCargarFotoPelicula_Click(object sender, EventArgs e)
        {
            //cargamos la imagen al picturebox
            ProcesarFoto.CargarImagen(ComponenteImagenPeliculas);
        }

        private void dataActores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            try
            {
                //Activamos el evento para saber los datos de la celda
                posicion = dataPeliculas.CurrentRow.Index;

                tID.Text = dataPeliculas[0, posicion].Value.ToString();
                tTituloPelicula.Text = dataPeliculas[1, posicion].Value.ToString();

                dateFechaPelicula.Value = DateTime.Parse(dataPeliculas[3, posicion].Value.ToString());

                //Traemos la foto desde la base de datos utilizando como parametro el ID de la celda donde se hizo el click
                string query = string.Format("Select * From Peliculas Where ID='{0}'", dataPeliculas[0, posicion].Value);
                DataSet data = OperacionesBD.Ejecutar(query);

                byte[] img = (byte[])data.Tables[0].Rows[0]["Foto"];
                MemoryStream memoryStream = new MemoryStream(img);
                ComponenteImagenPeliculas.Image = Image.FromStream(memoryStream);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error mientras se cargaban los datos, " +
                    "asegurese de que todos esten completos a la hora de seleccionarlos");
            }
        }

        private int EvaluarPeliculaGenero()
        {
            //Guardamos el indice del genero seleccionado en el comboBox
            int indiceComboBox = cGeneroPelicula.SelectedIndex;
            string GeneroSeleccionado = cGeneroPelicula.GetItemText(cGeneroPelicula.Items[indiceComboBox]);

            //Seleccionamos el Genero que el usuario selecciono, para enviarlo a la base de datos, debemos hacerlo asi
            //ya que lo que recibe la tabla es una fk del genero
            string query = string.Format("Select * From Generos Where NombreGenero='{0}'", GeneroSeleccionado);
            DataSet data = OperacionesBD.Ejecutar(query);
            int ID = Convert.ToInt32(data.Tables[0].Rows[0]["ID"]);
            return ID;
        }

        private async void btnNuevaPelicula_Click(object sender, EventArgs e)
        {
            try
            {
                //Procesamos la imagen
                byte[] fotografia = ProcesarFoto.ProcesarImagen(ComponenteImagenPeliculas);

                //Enviamos los datos
                await ManejoPeliculas.EditarPelicula(int.Parse(tID.Text), tTituloPelicula.Text, EvaluarPeliculaGenero(), dateFechaPelicula.Value, fotografia);
                MessageBox.Show("Pelicula Modificada Correctamente!");

                //Limpiamos los formularios
                this.LimpiarCampos();
                this.MostrarDatosPeliculas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No campos Vacios");
                errorProvider1.SetError(tTituloPelicula, "Ingresa el ID");
                errorProvider1.SetError(tTituloPelicula, "Ingresa el Titulo");

            }
        }

        private void LimpiarCampos()
        {
            tID.Clear();
            tTituloPelicula.Clear();
            dateFechaPelicula.ResetText();
            cGeneroPelicula.ResetText();
            ComponenteImagenPeliculas.Image = null;
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
