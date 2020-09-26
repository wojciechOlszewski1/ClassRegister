using ClassRegister.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRegister.Repository.Repositories
{
    interface IStudentRepository
    {
        IEnumerable<Student> GetStudents();
    }
}
