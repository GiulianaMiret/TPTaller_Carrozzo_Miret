using CodeHollow.FeedReader;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Vista
{
    static public class Utilidades
    {
        public static bool UrlValida(string pUrl)
        { 
        Uri mUriResult;
        bool mResult = Uri.TryCreate(pUrl, UriKind.Absolute, out mUriResult)
            && (mUriResult.Scheme == Uri.UriSchemeHttp || mUriResult.Scheme == Uri.UriSchemeHttps);
            return mResult;
        }

        /// <summary>
        /// Obtiene la disponibilidad o no de internet
        /// </summary>
        /// <returns>Verdadero si hay disponibilidad, Falso en caso contrario</returns>
        public static bool InternetDisponible()
        {
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                return false;
            else
                try
                {
                    (new System.Net.WebClient()).OpenRead("http://www.google.com");
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
        }

        public static string GetStringFromXMLRSSUrl (string pUrl)
        {
            var feedTask = FeedReader.ReadAsync(pUrl);
            string mResult = "";
            foreach (var mNoticia in feedTask.Result.Items)
            {
                mResult = mResult + mNoticia.Title + "-->" + mNoticia.Description + "-----------";
            }
            return mResult;
        }

        public static Bitmap ByteToImage(byte[] pImagen)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = pImagen;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap mBitMap = new Bitmap(mStream, false);
            mStream.Dispose();
            return mBitMap;
        }

        public static byte[] ImageToByteArray(PictureBox pPictureBox)
        {
                MemoryStream mMemoryStream = new MemoryStream();
                pPictureBox.Image.Save(mMemoryStream, System.Drawing.Imaging.ImageFormat.Png);
                return mMemoryStream.GetBuffer();
        }
        
    }
}
