using MudBlazor_CRUD.ApplicationDbContext;
using MudBlazor_CRUD.Models;
using MudBlazor_CRUD.UnitofWork;
using System.Collections.Generic;
using System.Linq;

namespace MudBlazor_CRUD.Services
{
    public class StudentService : IStudentService
    {
        #region Property  
        private IRepository<Student> _repository;
        private AppDbContext _appDbContext;
        #endregion

        #region Constructor  
        public StudentService(IRepository<Student> repository, AppDbContext appDbContext)
        {
            _repository = repository;
            _appDbContext = appDbContext;
        }
        #endregion

        public List<Student> GetStudents() => _repository.GetAll();

        public void InsertCustomer(Student customer) 
        {
            if (customer.StudentID is 0) _repository.Insert(customer);
            else _repository.Update(customer);
        } 

        public void DeleteCustomer(int id)
        {
            Student student = _appDbContext.Students.FirstOrDefault(c => c.StudentID.Equals(id));
            _repository.Remove(student);
            _repository.SaveChanges();
        }
    }
}
