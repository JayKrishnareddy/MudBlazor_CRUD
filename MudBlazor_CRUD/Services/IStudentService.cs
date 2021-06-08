using MudBlazor_CRUD.Models;
using System.Collections.Generic;

namespace MudBlazor_CRUD.Services
{
   public interface IStudentService
    {
        List<Student> GetStudents();
        void InsertStudent(Student customer);
        void DeleteStudent(int id);
    }
}
