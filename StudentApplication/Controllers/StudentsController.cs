using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StudentApplication.Models;

namespace StudentApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        public static List<Students> GetStudents()
        {
            List<Students> students = new List<Students>();
            students.Add(new Students() { Id = 1, First_name = "Valentin", Last_name = "Poli", Age = 19 });
            students.Add(new Students() { Id = 2, First_name = "Valentin", Last_name = "Poli", Age = 19 });
            students.Add(new Students() { Id = 3, First_name = "Valentin", Last_name = "Poli", Age = 19 });
            students.Add(new Students() { Id = 4, First_name = "Valentin", Last_name = "Poli", Age = 19 });
            students.Add(new Students() { Id = 5, First_name = "Valentin", Last_name = "Poli", Age = 19 });
            return students;
        }

        [HttpGet]
        public IEnumerable<Students> GetStudents_List()
        {
            return GetStudents();
        }

        [HttpGet("{id}")]
        public ActionResult<Students> GetStudents_ById(int id)
        {
            var students = GetStudents().Find(x => x.Id == id);
            if (students != null)
            {
                return students;
            }
            else
            {
                return NotFound();
            }
        }
    }
}