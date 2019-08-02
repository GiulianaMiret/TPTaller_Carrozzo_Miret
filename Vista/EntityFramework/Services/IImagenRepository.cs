using Core.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.EntityFramework.Services
{
    public interface IImagenRepository
    {
        void DeleteByHash(byte[] pHash);
        List<string> GetAllNamesFromImages();
        Imagen GetByHash(byte[] pImagen);
        Imagen GetByName(string pNombreImagen);
        void DeleteByName(string pName);
        Bitmap ByteToImage(byte[] pImagen);
        byte[] ImageToByteArray(PictureBox pPictureBox);
    }
}
