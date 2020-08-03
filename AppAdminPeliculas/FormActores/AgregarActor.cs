using CapaIntermedia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAdminPeliculas.FormActores
{
    public partial class AgregarActor : Form
    {
        public AgregarActor()
        {
            InitializeComponent();
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bCargarFotoActor_Click(object sender, EventArgs e)
        {
            //Cargamos la imagen utilizando el metodo correspondiente, y le pasamos el picturebox
            ProcesarFoto.CargarImagen(ComponenteImagen);

            //Ambos codigos hacen lo mismo

            //try
            //{
            //    OpenFileDialog fileDialog = new OpenFileDialog();
            //    DialogResult dialogResult = fileDialog.ShowDialog();

            //    if (dialogResult == DialogResult.OK || fileDialog.FileName != null)
            //    {
            //        ComponenteImagen.Image = Image.FromFile(fileDialog.FileName);
            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("Ocurrio un error al Procesar o cargar la imagen");
            //}
        }

        //Evaluamos el sexo seleccionado
        private char EvaluarSexo()
        {
            //Guardamos el indice del sexo seleccionado en el comboBox
            int indiceComboBox = cSexoActor.SelectedIndex;

            char sexo;
            if (cSexoActor.GetItemText(cSexoActor.Items[indiceComboBox]) == "Masculino")
            {
                sexo = 'M';
            }
            else
            {
                sexo = 'F';
            }

            return sexo;
        }

        private async void btnNuevaPelicula_Click(object sender, EventArgs e)
        {
            try
            {
                ////Guardamos la imagen en memoria
                //MemoryStream memoryStream = new MemoryStream();

                //ComponenteImagen.Image.Save(memoryStream, ImageFormat.Jpeg);

                //Procesamos la imagen para convertirla en []bytes y asi almacenarla en la bd
                byte[] fotografia = ProcesarFoto.ProcesarImagen(ComponenteImagen);

                await ManejoActores.NuevoActor(tNombre.Text, dateFechaActor.Value, EvaluarSexo(), fotografia);
                MessageBox.Show("Actor Registrado Correctamente!");

                //limpiamos los campos
                this.MostrarDatosActores();
                this.LimpiarCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No campos Vacios");
                errorProvider1.SetError(tNombre, "Ingresa el Nombre");
                errorProvider1.SetError(dateFechaActor, "Ingresa la fecha");
                errorProvider1.SetError(cSexoActor, "Ingresa el Sexo");
                errorProvider1.SetError(ComponenteImagen, "Ingresa la Foto");

            }
        }

        private void LimpiarCampos()
        {
            tNombre.Clear();
            dateFechaActor.ResetText();
            cSexoActor.ResetText();
            ComponenteImagen.Image = null;
        }

        private async void MostrarDatosActores()
        {
            dataActores.DataSource = await ManejoActores.MostrarActores();
        }


        private void AgregarActor_Load(object sender, EventArgs e)
        {
            this.MostrarDatosActores();
        }
    }
}
