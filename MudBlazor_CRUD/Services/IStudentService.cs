using MudBlazor_CRUD.Models;
using System.Collections.Generic;

namespace MudBlazor_CRUD.Services
{
   public interface IStudentService
    {
        List<Student> GetStudents();
        void InsertCustomer(Student customer);
        void DeleteCustomer(int id);
    }
}
