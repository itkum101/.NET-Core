using Task10___MVC_Controller_to_Views_.Models;
using Task10___MVC_Controller_to_Views_.Services;

namespace Task10___MVC_Controller_to_Views_.Repository
{
    public class StudentService : IStudentService
    {
        public List<Student> GetStudents() => new()
{
    new Student { Id = 1, Name = "Suman Sharma", Age = 20, Grade = "A", Email = "suman@example.com", PhoneNumber = "9801234567", Address = "Baneshwor, Kathmandu", EnrollmentDate = DateTime.Now.AddYears(-2) },
    new Student { Id = 2, Name = "Pratiksha Gurung", Age = 22, Grade = "B", Email = "pratiksha@example.com", PhoneNumber = "9812345678", Address = "Pokhara, Kaski", EnrollmentDate = DateTime.Now.AddYears(-3) },
    new Student { Id = 3, Name = "Bikash Thapa", Age = 21, Grade = "A+", Email = "bikash@example.com", PhoneNumber = "9845678901", Address = "Bhaktapur, Nepal", EnrollmentDate = DateTime.Now.AddYears(-1) },
    new Student { Id = 4, Name = "Anisha Rai", Age = 19, Grade = "A", Email = "anisha@example.com", PhoneNumber = "9823456789", Address = "Dharan, Sunsari", EnrollmentDate = DateTime.Now.AddYears(-1) },
    new Student { Id = 5, Name = "Ramesh Karki", Age = 23, Grade = "B+", Email = "ramesh@example.com", PhoneNumber = "9867890123", Address = "Butwal, Rupandehi", EnrollmentDate = DateTime.Now.AddYears(-4) }
};

    }
}
