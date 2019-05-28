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
        /// <summary>
        /// Obtiene la disponibilidad o no de internet
        /// </summary>
        /// <returns>Verdadero si hay disponibilidad, Falso en caso contrario</returns>
        private static bool InternetDisponible()
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

        private static TResult GetXmlNodeValue<TResult>(XmlNode pParentNode, String pChildNodeName)
        {
            if (pParentNode == null) { throw new ArgumentNullException("pParentNode"); }

            if (String.IsNullOrWhiteSpace(pChildNodeName)) { throw new ArgumentException("pChildNodeName"); }

            // Inicialmente se devuelve el valor por defecto del tipo genérico. Si es un objeto, este valor es null, en caso contrario depende del tipo.
            TResult mResult = default(TResult);

            // Tipo utilizado para la conversión final. Por defecto va a ser el mismo tipo genérico indicado.
            Type mConvertToType = typeof(TResult);

            XmlNode mChildNode = pParentNode.SelectSingleNode(pChildNodeName);

            // Si el nodo existe, entonces se obtiene el valor del texto del mismo para convertirlo al tipo genérico indicado.
            if (mChildNode != null)
            {
                // Se comprueba si el tipo es Nullable, ya que en dicho caso se debe convertir al tipo subyacente y no directamente al Nullable.
                if (Nullable.GetUnderlyingType(mConvertToType) != null)
                {
                    mConvertToType = Nullable.GetUnderlyingType(mConvertToType);
                }

                // Se realiza la conversión del texto del nodo al tipo adecuado, ya sea el tipo genérico indicado o bien al tipo subyacente del Nullable.
                mResult = (TResult)Convert.ChangeType(mChildNode.InnerText.Trim(), mConvertToType);
            }

            return mResult;
        }
        /// <summary>
        /// Devuelve el Feed Rss a partir de una cadena de texto.
        /// </summary>
        /// <param name="pUrl">Cadena de texto del url de la fuente Rss</param>
        /// <returns>Lista de Items Rss</returns>
        public static List<FuenteRSS> Feed(string pUrl) { return Feed(new Uri(pUrl)); }

        /// <summary>
        /// Devuelve el Feed Rss a partir de una Uri.
        /// </summary>
        /// <param name="pUrl">Uri que contenga el url de la fuente Rss</param>
        /// <returns></returns>
        public static List<FuenteRSS> Feed(Uri pUrl)
        {
            if (pUrl == null) { throw new ArgumentNullException("pUrl"); }

            if (!InternetDisponible()) { throw new Exception("Para poder hacer el Feed es indispensable internet."); }

            try
            {
                XmlTextReader mXmlReader = new XmlTextReader(pUrl.AbsoluteUri);

                XmlDocument mRssXmlDocument = new XmlDocument();

                mRssXmlDocument.Load(mXmlReader);

                List<FuenteRSS> mFuentes = new List<FuenteRSS>();

                foreach (XmlNode bRssXmlItem in mRssXmlDocument.SelectNodes("//channel/item"))
                {
                    mFuentes.Add(new FuenteRSS
                    {
                        Titulo = GetXmlNodeValue<String>(bRssXmlItem, "title"),
                        Descripcion = GetXmlNodeValue<String>(bRssXmlItem, "description"),
                        Fecha = GetXmlNodeValue<DateTime>(bRssXmlItem, "pubDate"),
                        URL = new Uri(GetXmlNodeValue<String>(bRssXmlItem, "link")).ToString()
                    }
                    );
                }

                return mFuentes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
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

        public static byte[] ImageToByteArray(PictureBox pPictureBox, string pExtension)
        {
            if (pExtension.ToUpper() == ".PNG")
            {
                MemoryStream mMemoryStream = new MemoryStream();
                pPictureBox.Image.Save(mMemoryStream, System.Drawing.Imaging.ImageFormat.Png);
                return mMemoryStream.GetBuffer();
            }
            else
            {
                MemoryStream mMemoryStream = new MemoryStream();
                pPictureBox.Image.Save(mMemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                return mMemoryStream.GetBuffer();
            }
        }
    }
}
