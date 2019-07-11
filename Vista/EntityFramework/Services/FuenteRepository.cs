using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using System.Linq.Expressions;
using System.Data.Entity;
using Vista.Core.Models;
using Vista.EntityFramework.Services;

namespace EntityFramework.Services
{
    /// <summary>
    /// Clase repositorio de la Fuente, donde se va a usar el context para realizar las operaciones
    /// </summary>
    public class FuenteRepository : IFuenteRepository
    {
        private DbSet<Fuente> cDbSetFuente;        

        public FuenteRepository(DigitalBillboardContext pContext)
        {
            cDbSetFuente = pContext.Set<Fuente>();
        }
    }
}
