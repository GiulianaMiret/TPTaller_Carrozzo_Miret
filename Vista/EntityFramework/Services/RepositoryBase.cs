using EntityFramework;
using EntityFramework.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Vista.EntityFramework.Services
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {
        private readonly DigitalBillboardContext cBillBoardContext;
        private DbSet<T> cDbSet;

        public RepositoryBase(DigitalBillboardContext pContext)
        {
            cBillBoardContext = pContext;
            cDbSet = pContext.Set<T>();
        }

        public void Add(T pEntity)
        {
            cDbSet.Add(pEntity);
        }

        public void Update(T pEntity)
        {
            if (cBillBoardContext.Entry(pEntity).State == EntityState.Detached)
            {
                cDbSet.Attach(pEntity);
            }
            cBillBoardContext.Entry(pEntity).State = EntityState.Modified;
        }

        public IQueryable<T> Filter(Expression<Func<T, bool>> expresion)
        {
            return cDbSet.Where(expresion);
        }

        public T GetById(int pId)
        {
            return cDbSet.Find(pId);
        }

        public void DeleteById(int pId)
        {
            T entityToDelete = cDbSet.Find(pId);
            this.Delete(entityToDelete);
        }

        public void Delete(T pEntity)
        {
            if (cBillBoardContext.Entry(pEntity).State == EntityState.Detached)
            {
                cDbSet.Attach(pEntity);
            }
            cDbSet.Remove(pEntity);            
            cBillBoardContext.SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
            return cDbSet;
        }

        public void SaveChanges()
        {
            cBillBoardContext.SaveChanges();
        }

    }
}
