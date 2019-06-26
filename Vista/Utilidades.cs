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

        public static void IniciarBanner(Label pLabel, int pTiempo)
        {
            for (int i = 0; i < pTiempo; i++)
            { 
                if (pLabel.Location.X == 0)
                {
                    pLabel.Location = new Point(500, pLabel.Location.Y);
                }
                pLabel.Location = new Point(pLabel.Location.X -1, pLabel.Location.Y);
                Task.Delay(1000);
            }
        }
        /// <summary>
        /// Devuelve el Feed Rss a partir de una cadena de texto.
        /// </summary>
        /// <param name="pUrl">Cadena de texto del url de la fuente Rss</param>
        /// <returns>Lista de Items Rss</returns>
      //  public static List<FuenteRSS> Feed(string pUrl) { return Feed(new Uri(pUrl)); }

        ///// <summary>
        ///// Devuelve el Feed Rss a partir de una Uri.
        ///// </summary>
        ///// <param name="pUrl">Uri que contenga el url de la fuente Rss</param>
        ///// <returns></returns>
        //public static List<FuenteRSS> Feed(Uri pUrl)
        //{
        //    if (pUrl == null) { throw new ArgumentNullException("pUrl"); }

        //    if (!InternetDisponible()) { throw new Exception("Para poder hacer el Feed es indispensable internet."); }

        //    try
        //    {
        //        XmlTextReader mXmlReader = new XmlTextReader(pUrl.AbsoluteUri);

        //        XmlDocument mRssXmlDocument = new XmlDocument();

        //        mRssXmlDocument.Load(mXmlReader);

        //        List<FuenteRSS> mFuentes = new List<FuenteRSS>();

        //        foreach (XmlNode bRssXmlItem in mRssXmlDocument.SelectNodes("//channel/item"))
        //        {
        //            mFuentes.Add(new FuenteRSS
        //            {
        //                Titulo = GetXmlNodeValue<String>(bRssXmlItem, "title"),
        //                Descripcion = GetXmlNodeValue<String>(bRssXmlItem, "description"),
        //                Fecha = GetXmlNodeValue<DateTime>(bRssXmlItem, "pubDate"),
        //                URL = new Uri(GetXmlNodeValue<String>(bRssXmlItem, "link")).ToString()
        //            }
        //            );
        //        }

        //        return mFuentes;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

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

        public static DialogResult MostrarMensajePopup(string pMensaje)
        {
            return MessageBox.Show(pMensaje);
        }
    }
}
