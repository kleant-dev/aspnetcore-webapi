using Microsoft.AspNetCore.Mvc;

namespace AppServiceDemo.Controllers;

[ApiController]
public class StudentController: ControllerBase
{
    [HttpGet("/")]
    public IActionResult Get()
    {
        List<Student> students =
        [
            new Student()
            {
                Age = 15,
                Name = "John Doe",
                Grade = 10,
                Credits = 30
            },

            new Student()
            {
                Name = "John Doe",
                Age = 20,
                Grade = 10,
                Credits = 40
            }
        ];
        return Ok(students);
    }
}