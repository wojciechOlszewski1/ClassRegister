using ClassRegister.Domain.Models;
using ClassRegister.Repository.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRegister.Repository.Repositories
{
    public class StudentReposiotry : IStudentRepository
    {
        private ClassRegisterContext _db;
        public StudentReposiotry(ClassRegisterContext db)
        {
            _db = db;
        }

        public IEnumerable<Student> GetStudents()
        {
            var students = _db.Students;
            return students;
        }
    }
}
