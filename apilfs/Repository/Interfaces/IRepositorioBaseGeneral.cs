using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface IRepositorioBaseGeneral<T> : IDisposable where T : class
    {
        /// <summary>
        /// Guarda los procesos realizados sobre la entidad
        /// </summary>
        /// <param name="entidad">Datos de la entidad</param>
        void Save(T entidad);

        /// <summary>
        /// Actualiza un registro de la base de datos
        /// </summary>
        /// <param name="entidad">Entidad con los datos a actualizar</param>
        void Update(T entidad);

        /// <summary>
        /// Elimina un registro de la entidad
        /// </summary>
        /// <param name="entidad"></param>
        void Delete(T entidad);

        /// <summary>
        /// Elimina un registro de la entidad en base a los parámetros enviados
        /// </summary>
        /// <param name="parametros">Parámetros de eliminación</param>
        void Delete(Expression<Func<T, bool>> parametros);

        /// <summary>
        /// Realiza la búsqueda por los parámetros especificados
        /// </summary>
        /// <param name="parametros">Parámetros de búsqueda</param>
        /// <returns>Los datos coincidentes</returns>
        IQueryable<T> FindBy(Expression<Func<T, bool>> parametros);        

        /// <summary>
        /// Obtiene todos los registros de la entidad
        /// </summary>
        /// <returns>Todos los registros de la entidad</returns>
        IQueryable<T> GetAll();

        /// <summary>
        /// Obtiene por el id principal o llave primaria un registro
        /// </summary>
        /// <param name="id">Identificador principal o llave primaria</param>
        /// <returns></returns>
        T GetById(long id);

        /// <summary>
        /// Obtiene un registro en base a los parámetros especificados
        /// </summary>
        /// <param name="parametros">Parámetros de búsqueda</param>
        /// <returns>Registro encontrado</returns>
        T Single(Expression<Func<T, bool>> parametros);

    }
}
