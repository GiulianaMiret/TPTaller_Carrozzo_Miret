using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace EntityFramework.Services
{
    /// <summary>
    /// Clase interfaz genérica de los repositorios
    /// </summary>
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Este método devuelve la lista completa de entidades
        /// </summary>
        IQueryable<T> GetAll();

        /// <summary>
        /// Este método obtiene una entidad (T) mediante el id
        /// </summary>
        /// <param name="pId"></param>
        /// <returns> T "entity" </returns>
        T GetById(int pId);

        /// <summary>
        /// Agrega una entidad (T)
        /// </summary>
        /// /// <param name="entity"></param>
        void Add(T entity);

        /// <summary>
        /// Borra una entidad por ID
        /// </summary>
        /// <param name="pId"></param>
        void DeleteById(int pId);

        /// <summary>
        /// Borra una entidad por ID
        /// </summary>
        /// <param name="pEntity"></param>
        void Delete(T pEntity);

        /// <summary>
        /// Modifica una entidad existente y Activa
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);

        /// <summary>
        /// Devuelve un objecto queryable filtrado por la expresion lambda
        /// </summary>
        /// <param name="pExpresion"></param>
        /// <returns></returns>
        IQueryable<T> Filter(Expression<Func<T, bool>> pExpresion);

        /// <summary>
        /// Guarda los cambios.
        /// </summary>
        void SaveChanges();
    }
}
