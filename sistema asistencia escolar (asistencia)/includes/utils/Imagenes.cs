using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_asistencia_escolar__asistencia_.includes.utils
{
    internal class Imagenes
    {
        /// <summary>
        /// Convierte una imagen en un arreglo de bytes
        /// </summary>
        /// <param name="img">imagen que convertiremos en un arreglo de bytes</param>
        /// <returns>un arreglo de bytes de la imagen ingresada</returns>
        public static byte[] ImagenToByteArray(Image img)
        {
            string sTemp = Path.GetTempFileName();
            FileStream fs = new FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            img.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
            fs.Position = 0;

            int imgLength = Convert.ToInt32(fs.Length);
            byte[] bytes = new byte[imgLength];
            fs.Read(bytes, 0, imgLength);
            fs.Close();
            return bytes;
        }

        /// <summary>
        /// Convierte un arreglo de bytes en una imagen
        /// </summary>
        /// <param name="byteImage">arreglo de bytes</param>
        /// <returns>una imagen construida de un arreglo de bytes</returns>
        public static Image ByteArrayToImagen(byte[] byteImage)
        {
            using (var ms = new MemoryStream(byteImage))
            {
                return System.Drawing.Image.FromStream(ms);
            }
        }
    }
}
