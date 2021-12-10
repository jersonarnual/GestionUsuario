using GestionUsuario.Data.Context;
using GestionUsuario.Data.Interface;
using GestionUsuario.Data.Models.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GestionUsuario.Data.Repository
{
    public class DefaultRepository<T> : IDefaultRepository<T> where T : BaseEntity
    {
        #region Members
        private readonly GestionContext _context;
        private readonly DbSet<T> table;
        #endregion


        #region Ctor
        public DefaultRepository(GestionContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }
        #endregion

        #region Methods
        public IEnumerable<T> GetAll()
        {
            return table.AsQueryable();
        }
        public T GetById(Guid id)
        {
            return table.AsQueryable().FirstOrDefault(x =>  x.Id == id);
        }

        public bool Insert(T entity)
        {
            try
            {
                if (string.IsNullOrEmpty(entity.Id.ToString()) || entity.Id == Guid.Empty)
                    entity.Id = Guid.NewGuid();
                table.Add(entity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Update(T entity)
        {
            try
            {
                entity.UpdateTime = DateTime.Now;
                table.Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                table.Remove(entity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
    }
}

