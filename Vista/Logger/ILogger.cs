using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista.Logger
{
    public interface ILogger
    {
        void Info(string pMensaje, Exception pException);
        void Debug(string pMensaje, Exception pException);
        void Error(string pMensaje, Exception pException);
        void Warn(string pMensaje, Exception pException);
        void Fatal(string pMensaje, Exception pException);
        void Info(string pMensaje);
        void Debug(string pMensaje);
        void Error(string pMensaje);
        void Warn(string pMensaje);
        void Fatal(string pMensaje);
    }
}
