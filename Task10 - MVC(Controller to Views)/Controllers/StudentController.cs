namespace Task10___MVC_Controller_to_Views_.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Task10___MVC_Controller_to_Views_.Services;

    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IActionResult Index()
        {
            var students = _studentService.GetStudents();
            return View(students);
        }
    }

}
