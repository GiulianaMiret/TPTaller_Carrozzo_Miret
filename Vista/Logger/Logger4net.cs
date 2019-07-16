using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista.Logger
{
    public class Logger4net : ILogger
    {
        private readonly ILog cLogger;
        public Logger4net()
        {
            cLogger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }
        public void Info(string pMensaje, Exception pException)
        {
            cLogger.Info(pMensaje, pException);
        }
        public void Debug(string pMensaje, Exception pException)
        {
            cLogger.Debug(pMensaje, pException);
        }
        public void Warn(string pMensaje, Exception pException)
        {
            cLogger.Warn(pMensaje, pException);
        }
        public void Fatal(string pMensaje, Exception pException)
        {
            cLogger.Fatal(pMensaje, pException);
        }
        public void Error(string pMensaje, Exception pException)
        {
            cLogger.Error(pMensaje, pException);
        }


        public void Info(string pMensaje)
        {
            cLogger.Info(pMensaje);
        }
        public void Debug(string pMensaje)
        {
            cLogger.Debug(pMensaje);
        }
        public void Warn(string pMensaje)
        {
            cLogger.Warn(pMensaje);
        }
        public void Fatal(string pMensaje)
        {
            cLogger.Fatal(pMensaje);
        }
        public void Error(string pMensaje)
        {
            cLogger.Error(pMensaje);
        }
    }
}
