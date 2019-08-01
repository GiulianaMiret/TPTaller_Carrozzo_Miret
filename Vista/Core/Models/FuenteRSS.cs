using EntityFramework.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vista;
using Vista.Core.Models;

namespace Core.Models
{
    public class FuenteRSS : Fuente
    {
        private readonly IRepository<FuenteRSS> cRepositoryBaseRSS;

        public FuenteRSS()
        {
            cRepositoryBaseRSS = (CompositionRoot.Resolve<IRepository<FuenteRSS>>());
        }
        [DataType(DataType.Url)]

        public string URL { get; set; }

        public override string Valor { get; set; }

        public override void Actualizar()
        {
            if (Utilidades.InternetDisponible())
            { 
                this.Valor = Utilidades.GetStringFromXMLRSSUrl(this.URL);
                cRepositoryBaseRSS.Update(this);
                cRepositoryBaseRSS.SaveChanges();
            }
        }
    }
}
