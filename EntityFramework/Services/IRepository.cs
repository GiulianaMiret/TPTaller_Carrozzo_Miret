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
        /// Este metodo devuelve un conjunto de T (Banners, Campanias, etc) obtenidos segun la expresion pasada como parámetro
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns> conjunto de T "entity" </returns>
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Este método devuelve una entidad (T) obtenido por el id indicado como parámetro si se encuentra ACTIVA (Estado == true)
        /// </summary>
        /// <param name="pId"></param>
        /// <returns> T "entity" </returns>
        T FindById(int pId);

        /// <summary>
        /// Este método devuelve la lista completa de entidades ACTIVAS (Estado == true)
        /// </summary>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Este método obtiene una entidad (T) mediante el id si la entidad se encuentra ACTIVA (Estado == true)
        /// </summary>
        /// <param name="pId"></param>
        /// <returns> T "entity" </returns>
        T GetById(int pId);

        /// <summary>
        /// Agrega una entidad (T) verificando que no exista o no esté activa.
        /// Si la entidad habia sido borrada (Estado == false), se la vuelve a activar (Estado == true)
        /// </summary>
        /// /// <param name="entity"></param>
        void Insert(T entity);

        /// <summary>
        /// Da de baja lógica (Estado == false) un nuevo elemento de la lista de ACTIVOS (Estado == true) pasando la entidad
        /// </summary>
        /// <param name="entity"></param>
        void Delete(T entity);


        /// <summary>
        /// Da de baja lógica (Estado == false) un nuevo elemento de la lista de ACTIVOS (Estado == true) pasando el ID
        /// </summary>
        /// <param name="pId"></param>
        void DeleteById(int pId);

        /// <summary>
        /// Modifica una entidad existente y Activa
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);

        /// <summary>
        /// Guarda los cambios en la base de datos
        /// </summary>
        void Save();
    }
}
