using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace mvcapp
{
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        Student[] students = new Student[]
             {
            new Student { Id = 1, Name = "James Soup",  Age = 21 },
            new Student { Id = 2, Name = "Humain -yo", Age = 20 },
            new Student { Id = 3, Name = "Hammer" ,Age = 22 }
             };

        [HttpGet]     
        public IEnumerable<Student> GetAll()
        {
            return students;
        }
        [HttpGet("{id}")]

        public IActionResult Get(int id)
        {
            var student = students.FirstOrDefault((s) => s.Id == id);
            if (student == null)
            {

                return NotFound();
            }
            return Ok(student);
        }
    }
}