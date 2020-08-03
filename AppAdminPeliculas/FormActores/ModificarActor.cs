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

namespace AppAdminPeliculas.FormActores
{
    public partial class ModificarActor : Form
    {
        
        public ModificarActor()
        {
            InitializeComponent();
        }
        private async void MostrarDatosActores()
        {
            dataActores.DataSource = await ManejoActores.MostrarActores();
        }

        private void ModificarActor_Load(object sender, EventArgs e)
        {
            this.MostrarDatosActores();
        }

        //Funcion para evaluar el sexo seleccionado por el usuario en el combobox
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

        private void btnCargarFotoActor_Click(object sender, EventArgs e)
        {
            //Llamamos el metodo para cargar la imagen en el PictureBox y  le enviamos el PictureBox donde la va a cargar.
            ProcesarFoto.CargarImagen(ComponenteImagen);
        }

        //Este metodo es para cuando hacemos click en una de las celdas, se llenen los textbox con los valores de dicha celda, es como un especie de seleccion
        private void dataActores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int posicion;
                posicion = dataActores.CurrentRow.Index;

                tID.Text = dataActores[0, posicion].Value.ToString();
                tNombreActor.Text = dataActores[1, posicion].Value.ToString();
                dateFechaActor.Value = DateTime.Parse(dataActores[2, posicion].Value.ToString());

                //Hacemos un query para traer la imagen desde la base de datos
                string query = string.Format("Select * From Actores Where ID='{0}'", dataActores[0, posicion].Value);
                DataSet data = OperacionesBD.Ejecutar(query);

                //Convertimos dicha imagen en un arreglo de bytes, y la mostramos.
                byte[] img = (byte[])data.Tables[0].Rows[0]["Foto"];
                MemoryStream memoryStream = new MemoryStream(img);
                ComponenteImagen.Image = Image.FromStream(memoryStream);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error mientras se cargaban los datos, " +
                    "asegurese de que todos esten completos a la hora de seleccionarlos");
            }
           
        }

        private async void btnModificarActor_Click(object sender, EventArgs e)
        {
            try
            {
                //Llamamos al metodo que se encarga de procesar la imagen y convertirla a un arreglo de bytes
                byte[] fotografia = ProcesarFoto.ProcesarImagen(ComponenteImagen);

                //Enviamos los datos recibidos del formulario al metodo correspondiente para que este realice su tarea.
                await ManejoActores.EditarActor(int.Parse(tID.Text), tNombreActor.Text, dateFechaActor.Value, EvaluarSexo(), fotografia);
                MessageBox.Show("Actor Modificado Correctamente!");

                //Una vez que se modifica, hacemos una especie de refresh y limpiamos los campos
                this.MostrarDatosActores();
                this.LimpiarCampos();
            }
            catch (Exception ex)
            {
                //En caso de que hayan campos vacios, le indicamos al usuario cuales son
                MessageBox.Show("No campos Vacios");
                errorProvider1.SetError(tID, "Ingresa el ID");
                errorProvider1.SetError(tNombreActor, "Ingresa el Nombre");
                errorProvider1.SetError(cSexoActor, "Selecciona el Sexo");
            }
        }

        //Funcion para limpiar los textbos
        private void LimpiarCampos()
        {
            tID.Clear();
            tNombreActor.Clear();
            dateFechaActor.ResetText();
            cSexoActor.ResetText();
            ComponenteImagen.Image = null;
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
