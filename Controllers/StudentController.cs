using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolApp.API.Data;

namespace SchoolApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly DataContext _context;
        
        public StudentController(DataContext context)
        {
            _context=context;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllStudent()
        {
            var Students = await _context.Students.ToListAsync();
            return Ok(Students);

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudentById(int id)
        {
            var Student = await _context.Students.FirstOrDefaultAsync (x => x.StudentId == id);
            return Ok(Student);
        }
    } 
}