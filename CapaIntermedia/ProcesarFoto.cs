using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace CapaIntermedia
{
    public class ProcesarFoto
    {
        /*Dentro de esta clase, inclui los metodos que sirven para cargar la imagen y mostrarla en el pictureBox,
         * y el otro sirve para procesar la imagen y convertirla a un arreglo de bits para enviarsela a la bd.
         * 
         * Decidi hacerlo de esta manera, porque en varias partes del programa necesito implementar esta funcionalidad
         * entonces para no tener que estar repitiendo codigo, mejor lo traje a un metodo y le envio los parametros
         * correspondientes para que estos realicen sus tareas
        */

        public static void CargarImagen(PictureBox ComponenteImagen)
        {
            try
            {
               //Le permitimos al usuario que seleccione el archivo
                OpenFileDialog fileDialog = new OpenFileDialog();

                //Estos son los formatos permitidos
                fileDialog.Filter = "Image Files (JPG, JPEG, PNG)|*.JPG;*.JPEG;*.PNG";

                DialogResult dialogResult = fileDialog.ShowDialog();

                //Si el nombre del archivo es nulo, es porque no se selecciono ningun archivo, por lo cual validamos eso
                if (dialogResult == DialogResult.OK || fileDialog.FileName != null)
                {
                    //Por ultimo mostramos la imagen en el PictureBox
                    ComponenteImagen.Image = Image.FromFile(fileDialog.FileName);
                    ComponenteImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al Procesar o cargar la imagen");
            }
        }

        public static byte[] ProcesarImagen(PictureBox ComponenteImagen)
        {
            //Guardamos la imagen en memoria
            MemoryStream memoryStream = new MemoryStream();

            //Convertirmos la imagen en JPEG
            ComponenteImagen.Image.Save(memoryStream, ImageFormat.Jpeg);

            //La acoplamos al pictureBox
            ComponenteImagen.SizeMode = PictureBoxSizeMode.StretchImage;

            //retornamos el arreglo de bits
            return memoryStream.GetBuffer();
        }
    }
}
