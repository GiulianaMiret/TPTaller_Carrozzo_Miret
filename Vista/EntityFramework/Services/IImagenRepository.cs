using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista.EntityFramework.Services
{
    public interface IImagenRepository
    {
        void DeleteByHash(byte[] pHash);
        List<string> GetAllNamesFromImages();
        Imagen GetByHash(byte[] pImagen);
        Imagen GetByName(string pNombreImagen);
        void DeleteByName(string pName);
    }
}
