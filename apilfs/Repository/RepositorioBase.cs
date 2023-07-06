using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using apilfs.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using apilfs.Models;

namespace apilfs.Repository
{
    public class RepositorioBase<T> : IRepositorioBaseGeneral<T> where T : class
    {
        protected readonly BD_LFSContext Contexto;
        public RepositorioBase(BD_LFSContext _Contexto)
        {
            Contexto = _Contexto;
        }

        /// <summary>
        /// Se utiliza para indicar que ya se marco para liberar
        /// el espacio usado por la clase en memoria.
        /// </summary>
        bool _disposed;

        /// <summary>
        /// Contexto
        /// </summary>
        
        /// <summary>
        /// Realiza una búsqueda acorde a una expresión
        /// </summary>
        /// <param name="parametros"></param>
        /// <returns></returns>
        public IQueryable<T> FindBy(Expression<Func<T, bool>> parametros)
        {
            return Contexto.Set<T>().Where(parametros);
        }       

        /// <summary>
        /// Obtiene todos los registros
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> GetAll()
        {
            return Contexto.Set<T>();
        }

        

        /// <summary>
        /// Obtiene un registro por su identificador principal
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetById(long id)
        {
            return Contexto.Set<T>().Find(id);
        }

        /// <summary>
        /// Obtiene un registro en base a los parámetros especificados
        /// </summary>
        /// <param name="parametros">Parámetros de búsqueda</param>
        /// <returns>Registro encontrado</returns>
        public T Single(Expression<Func<T, bool>> parametros)
        {
            return Contexto.Set<T>().FirstOrDefault(parametros);
        }
        

        /// <summary>
        /// Agrega un nuevo registro a la base de datos
        /// </summary>
        /// <param name="entidad">Entidad que se desea insertar o editar en la base de datos</param>
        public void Save(T entidad)
        {
            Contexto.Set<T>().Add(entidad);
            Contexto.SaveChanges();
        }

        /// <summary>
        /// Actualiza un registro de la base de datos
        /// </summary>
        /// <param name="entidad">Entidad con los datos a actualizar</param>
        public void Update(T entidad)
        {
            Contexto.Entry(entidad).State = EntityState.Modified;
            Contexto.SaveChanges();
        }

        /// <summary>
        /// Elimina un registro de la base de datos
        /// </summary>
        /// <param name="entidad">Registro que se desea eliminar</param>
        public void Delete(T entidad)
        {
            Contexto.Set<T>().Remove(entidad);
            Contexto.SaveChanges();
        }

        /// <summary>
        /// Elimina un registro de la entidad en base a los parámetros enviados
        /// </summary>
        /// <param name="parametros">Parámetros de eliminación</param>
        public void Delete(Expression<Func<T, bool>> parametros)
        {
            var entidadesEncontradas = Contexto.Set<T>().Where(parametros).ToList();
            entidadesEncontradas.ForEach(x => Contexto.Entry(x).State = EntityState.Deleted);
            Contexto.SaveChanges();
        }
       

        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Libera los recursos no administrados que utiliza el objeto y, opcionalmente, libera los recursos administrados.
        /// </summary>
        /// <param name="disposing">
        /// true para liberar tanto los recursos administrados como los no administrados; false para liberar 
        /// únicamente los recursos no administrados.
        /// </param>
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
                Contexto.Dispose();

            _disposed = true;
        }
    }
}
