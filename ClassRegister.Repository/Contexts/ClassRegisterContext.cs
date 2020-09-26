using ClassRegister.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRegister.Repository.Contexts
{
    public class ClassRegisterContext : DbContext
    {
        public DbSet<Student> Students { get; set; } 

        public ClassRegisterContext(DbContextOptions<ClassRegisterContext> options)
        : base(options)
        { }

    }
}


