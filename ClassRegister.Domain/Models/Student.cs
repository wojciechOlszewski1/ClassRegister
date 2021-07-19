using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRegister.Domain.Models
{
    public class Student : Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
