using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassRegister.Dtos;
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
        public StudentsController(IStudentRepository studentRepository)
        {
            _studentReposiotry = studentRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_studentReposiotry.GetStudents());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var student = _studentReposiotry.GetById(id);

            var studentDto = new StudentDto();
            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        [HttpPost]
        public IActionResult Post([FromBody] StudentDto student)
        {

            return Ok(student);
        }
    }
}
