using Microsoft.EntityFrameworkCore;
using MudBlazor_CRUD.ApplicationDbContext;
using MudBlazor_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MudBlazor_CRUD.UnitofWork
{
    public class Repository<T> : IRepository<T> where T : Student
    {
        #region property  
        private readonly AppDbContext _applicationDbContext;
        private DbSet<T> entities;
        #endregion

        #region Constructor  
        public Repository(AppDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            entities = _applicationDbContext.Set<T>();
        }
        #endregion

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            _applicationDbContext.SaveChanges();
        }


        public List<T> GetAll()
        {
            return entities.ToList();
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            _applicationDbContext.SaveChanges();
        }

        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }

        public void SaveChanges()
        {
            _applicationDbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            _applicationDbContext.SaveChanges();
        }
    }
}
