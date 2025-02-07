using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7___ExceptionHandling
{

    public class StudentRepository 
    {
        private List<Student> students = new List<Student>
    {
        new Student { StudentId = 1, Name = "Ram Sharma", Gender = "Male", Age = 20, IsEnrolled = true },
        new Student { StudentId = 2, Name = "Sita Bhattarai", Gender = "Female", Age = 21, IsEnrolled = true },
        new Student { StudentId = 3, Name = "Ganesh Tamang", Gender = "Male", Age = 22, IsEnrolled = false }, // Not enrolled
        new Student { StudentId = 4, Name = "Laxmi Gurung", Gender = "Female", Age = 19, IsEnrolled = true },
        new Student { StudentId = 5, Name = "Bikash Maharjan", Gender = "Male", Age = 23, IsEnrolled = false } // Not enrolled
    };

        public List<Student> GetAll()
        {
            return students;
        }

        public Student GetStudentById(int studentId)
        {
            var student = students.FirstOrDefault(s => s.StudentId == studentId);

            if (student == null)
                throw new ArgumentException($"Student with ID {studentId} doesn't exist");

            if (!student.IsEnrolled)
                throw new StudentException($"Student {student.Name} with {student.StudentId} is not enrolled.");

            return student;
        }
    }

}
