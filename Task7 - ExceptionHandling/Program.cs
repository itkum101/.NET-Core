namespace Task7___ExceptionHandling
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var studentRepo = new StudentRepository();

            try
            {
                Console.WriteLine("Enter Student ID");

                int studentId = int.Parse(Console.ReadLine());

                Student student = studentRepo.GetStudentById(studentId);

                Console.WriteLine($"Student was enrolled: {student.Name}, Age: {student.Age}, Gender: {student.Gender}");
            }
            catch (StudentException ex)
            {
                Console.WriteLine($"Enrollment Error: {ex.Message}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
            }
        }
    }

}
