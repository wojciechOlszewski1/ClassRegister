using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassRegister.Repository.Contexts;
using ClassRegister.Repository.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClassRegister.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private IStudentRepository _studentReposiotry;
        public StudentsController(ClassRegisterContext classRegisterContext)
        {
            _studentReposiotry = new StudentReposiotry(classRegisterContext);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_studentReposiotry.GetStudents());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_studentReposiotry.GetStudents());
        }
    }
}
