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
        /// <summary>
        /// Metodo que devuelve true o false, dependiendo si el string pasado como parametro
        ///     es una URL válida.
        /// </summary>
        /// <param name="pUrl"></param>
        /// <returns></returns>
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
                throw new Exception("Por favor conéctese a internet para actualizar las fuentes RSS.");
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
        /// <summary>
        /// Metodo que dado una URL, devuelve un string, con todos los feeds leídos del RSS concatenados.
        /// </summary>
        /// <param name="pUrl"></param>
        /// <returns></returns>
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
    }
}
