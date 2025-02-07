using Task6___LINQ.Repositories;

namespace Task6___LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employeeRepo = new EmployeeRepository();
            var studentRepo = new StudentRepository();
            var numberRepo = new NumberRepository();

            var employees = employeeRepo.GetAll();
            var students = studentRepo.GetAll();
            var numbers = numberRepo.GetAll();

            DisplayEmployeesOlderThanThirty(employees);
            DisplaySortedStudents(students);
            DisplayEvenNumbers(numbers);
        }

        private static void DisplayEmployeesOlderThanThirty(List<Employee> employees)
        {
            var employeesOlderThanThirty = employees.Where(emp => emp.Age > 30);

            Console.WriteLine("Employees older than 30:");
            foreach (var employee in employeesOlderThanThirty)
            {
                Console.WriteLine($"Name: {employee.Name}, Age: {employee.Age}");
            }
        }

        private static void DisplaySortedStudents(List<Student> students)
        {
            var sortedStudents = students.OrderByDescending(student => student.Name);

            Console.WriteLine("Sorted Students (Descending Order):");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"ID: {student.StudentId}, Name: {student.Name}, Gender: {student.Gender}, Age: {student.Age}");
            }
        }

        private static void DisplayEvenNumbers(List<int> numbers)
        {
            var evenNumbers = numbers.Where(num => num % 2 == 0);

            Console.WriteLine("\nEven Numbers:");
            Console.WriteLine(string.Join(", ", evenNumbers));
        }
    }
}
