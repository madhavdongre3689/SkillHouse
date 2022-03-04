using Microsoft.AspNetCore.Mvc;
using StudentWebAPI.DbContext;
namespace StudentWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {

        ApplicationDbContext dbContext = new ApplicationDbContext();


        [HttpGet]
        [Route("GetStudents")]

        public List<Student> GetStudents()
        {
            return dbContext.Students.ToList();
        }

    }
}