using MudBlazor_CRUD.Models;
using System.Collections.Generic;

namespace MudBlazor_CRUD.UnitofWork
{
   public interface IRepository<T> where T : Student
    {
        List<T> GetAll();
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}
