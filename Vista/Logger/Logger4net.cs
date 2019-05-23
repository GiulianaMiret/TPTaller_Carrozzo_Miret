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
        private readonly ILog iLogger;
        public Logger4net()
        {
            iLogger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }
        public void Info(string pMensaje, Exception pException)
        {
            iLogger.Info(pMensaje, pException);
        }
        public void Debug(string pMensaje, Exception pException)
        {
            iLogger.Debug(pMensaje, pException);
        }
        public void Warn(string pMensaje, Exception pException)
        {
            iLogger.Warn(pMensaje, pException);
        }
        public void Fatal(string pMensaje, Exception pException)
        {
            iLogger.Fatal(pMensaje, pException);
        }
        public void Error(string pMensaje, Exception pException)
        {
            iLogger.Error(pMensaje, pException);
        }


        public void Info(string pMensaje)
        {
            iLogger.Info(pMensaje);
        }
        public void Debug(string pMensaje)
        {
            iLogger.Debug(pMensaje);
        }
        public void Warn(string pMensaje)
        {
            iLogger.Warn(pMensaje);
        }
        public void Fatal(string pMensaje)
        {
            iLogger.Fatal(pMensaje);
        }
        public void Error(string pMensaje)
        {
            iLogger.Error(pMensaje);
        }
    }
}
