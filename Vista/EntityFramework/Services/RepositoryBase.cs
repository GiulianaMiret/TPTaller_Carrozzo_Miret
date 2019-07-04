using EntityFramework;
using EntityFramework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista.EntityFramework.Services
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {
        private readonly DigitalBillboardContext cBillBoardContext;

        public RepositoryBase(DigitalBillboardContext pContext)
        {
            cBillBoardContext = pContext;
        }


        public void DeleteById(int pId)
        {

        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int pId)
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
