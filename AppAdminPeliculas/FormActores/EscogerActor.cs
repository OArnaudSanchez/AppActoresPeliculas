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
    public partial class EscogerActor : Form
    {
        public EscogerActor()
        {
            InitializeComponent();
        }

        //Variables estaticas, que usaremos en otras clases
        public static int ID;
        public static string Nombre;
        public static string FechaNacimiento;

        private async void EscogerActor_Load(object sender, EventArgs e)
        {
            dataActores.DataSource = await ManejoActores.MostrarActores();
        }

        private void dataActores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Para seleccionar un actor, solo debemos hacer click en la celda.
            try
            {
                int posicion;
                posicion = dataActores.CurrentRow.Index;


                if (MessageBox.Show("Desea Seleccionar Este actor??", "Informacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    //Almacenamos los valores del actor que seleccionamos
                    ID = int.Parse(dataActores[0, posicion].Value.ToString());
                    Nombre = dataActores[1, posicion].Value.ToString();
                    FechaNacimiento = dataActores[2, posicion].Value.ToString();

                    MessageBox.Show("Actor seleccionado correctamente. Se cerrara la ventana para proceder");
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
