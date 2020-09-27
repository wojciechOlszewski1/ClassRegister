using ClassRegister.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRegister.Repository.Repositories
{
    public interface IStudentRepository
    {
        Student GetById(int id);
        IEnumerable<Student> GetStudents();
    }
}
