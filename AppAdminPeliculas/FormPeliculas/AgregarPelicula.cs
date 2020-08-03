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
    public partial class AgregarPelicula : Form
    {
        public AgregarPelicula()
        {
            InitializeComponent();
        }

        private void btnCargarFotoPelicula_Click(object sender, EventArgs e)
        {
            ProcesarFoto.CargarImagen(ComponenteImagenPelicula);
        }

        private int EvaluarPeliculaGenero()
        {
            //Guardamos el indice del sexo seleccionado en el comboBox
            int indiceComboBox = cGeneroPelicula.SelectedIndex;
            string GeneroSeleccionado = cGeneroPelicula.GetItemText(cGeneroPelicula.Items[indiceComboBox]);

            //hacemos una consulta a la base de datos para saber el ID del genero que el usuario selecciono
            string query = string.Format("Select * From Generos Where NombreGenero='{0}'", GeneroSeleccionado);
            DataSet data = OperacionesBD.Ejecutar(query);
            int ID = Convert.ToInt32(data.Tables[0].Rows[0]["ID"]);
            return ID;
        }

        private async void btnNuevaPelicula_Click(object sender, EventArgs e)
        {
            try
            {
                //Hacemos una consulta nuevamente, para validar que no se ingrese una pelicula que ya existe
                string comando = string.Format($"select count(Titulo) as Conteo from Peliculas where Titulo='{tTituloPelicula.Text}'");
                DataSet data = OperacionesBD.Ejecutar(comando);
                string PeliculaRepetida = data.Tables[0].Rows[0]["Conteo"].ToString().Trim();

                if (int.Parse(PeliculaRepetida) > 0)
                {
                    //En caso de que exista
                    MessageBox.Show("El nombre de la pelicula que intenta ingresar ya existe");
                }
                else
                {
                    //Procesamos la imagen para enviarla a la base de datos como un arreglo de bytes
                    byte[] fotografia = ProcesarFoto.ProcesarImagen(ComponenteImagenPelicula);

                    //Mandamos los valores al metodo correspondiente
                    await ManejoPeliculas.NuevaPelicula(tTituloPelicula.Text, EvaluarPeliculaGenero(), dateFechaPelicula.Value, fotografia);
                    MessageBox.Show("Pelicula Agregada Correctamente");

                    //Limpiamos los campos y actualizamos los datos.
                    this.LimpiarCampos();
                    this.MostrarDatosPeliculas();
                }

                
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(tTituloPelicula, "Ingresa el Titulo");
                errorProvider1.SetError(dateFechaPelicula, "Ingresa la fecha");
                errorProvider1.SetError(cGeneroPelicula, "Ingresa el Genero");
                errorProvider1.SetError(ComponenteImagenPelicula, "Ingresa la Foto");
                MessageBox.Show("NO Campos Vacios");
            }
        }

        private void LimpiarCampos()
        {
            tTituloPelicula.Clear();
            dateFechaPelicula.ResetText();
            cGeneroPelicula.ResetText();
            ComponenteImagenPelicula.Image = null;
        }

        private void AgregarPelicula_Load(object sender, EventArgs e)
        {
            this.MostrarDatosPeliculas();
        }

        private async void MostrarDatosPeliculas()
        {
            dataPeliculas.DataSource = await ManejoPeliculas.MostrarPeliculas();
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
