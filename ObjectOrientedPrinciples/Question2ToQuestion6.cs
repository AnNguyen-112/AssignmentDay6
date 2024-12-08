using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay6.ObjectOrientedPrinciples
{
    internal class Question2ToQuestion6
    {

    }

    //abstraction
    public class Person : IPersonService
    {
        public string Name { get;  private set; }

        public DateTime DateOfBirth { get; private set; }

        //Encapsulation
        private decimal _salary;
        private List<string> _addresses = new();

        public Person(string name, DateTime dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
        }
        public decimal Salary
        {
            get => _salary;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Salary cannot be negative.");
                _salary = value;
            }
        }

        public int CalculateAge(DateTime dateOfBirth)
        {
            var today = DateTime.Now;
            var age = today.Year - dateOfBirth.Year;
            if (dateOfBirth > today.AddYears(-age)) age--;
            return age;
        }

        public void addAddress(string address) => _addresses.Add(address);
        public IEnumerable<string> GetAddresses() => _addresses;
    }

    //Inheritance
    public class Instructor : Person, IInstructorService
    {
        

        public string Department { get ; set ; }
        public bool IsHead { get; set; }
        public DateTime JoinDate { get; set; }

        public Instructor(string name, DateTime dateOfBirth, string department, DateTime joinDate) : base(name, dateOfBirth)
        {
            Department = department;
            JoinDate = joinDate;
        }

        public decimal CalculateSalary()
        {
            return Salary + (YearsOfExperience(JoinDate) * 500);
        }

        //Polymorphism (compile time, overloading)
        public decimal CalculateSalary(string title)
        {
            return Salary + (YearsOfExperience(JoinDate) * 500);
        }

        public int YearsOfExperience(DateTime joinedDate)
        {
            return (DateTime.Now - joinedDate).Days / 365;
        }
    }

    public class Student : Person, IStudentService
    {
        //Encapsulation
        private Dictionary<string, char> _courses = new();

        

        public void EnrollInCourse(string courseName, char grade) => _courses[courseName] = grade;
        public Student(string name, DateTime dateOfBirth) : base(name, dateOfBirth)
        {
            
        }

        public double CalculateGPA()
        {
            if (_courses.Count == 0) return 0.0;
            int totalPoints = 0;
            foreach (var grade in _courses.Values)
            {
                totalPoints += grade switch
                {
                    'A' => 4,
                    'B' => 3,
                    'C' => 2,
                    'D' => 1,
                    'F' => 0,
                    _ => throw new ArgumentException("Invalid grade.")
                };
            }
            return totalPoints / (double)_courses.Count;
        }

        
    }

    public class Course : ICourseService
    {
         public string _name { get; private set; }

        private List<Student> _enrolledStudents = new();

        public Course(string name)
        {
            _name = name;
        }

        public void EnrollStudent(Student student)
        {
            _enrolledStudents.Add(student);
        }

        public IEnumerable<Student> GetEnrolledStudents()
        {
            return _enrolledStudents;
        }
    }

    public class Department : IDepartmentService
    {
        public string Name{ get ; set; }
        public Instructor HeadInstructor { get; set; }
        public decimal Budget { get; set; }
        private List<Course> _courses = new();

        public Department(string name, Instructor head, decimal budget)
        {
            Name = name;
            HeadInstructor = head;
            Budget = budget;
        }

        public void OfferCourse(Course course) => _courses.Add(course);
        public IEnumerable<Course> GetCourses() => _courses;
    }

    //interface - abstraction
    interface IPersonService
    {
        int CalculateAge(DateTime dateOfBirth);
        decimal Salary { get; set; }
        void addAddress (string address);
        IEnumerable<string> GetAddresses();
    }

    interface ICourseService
    {
        string _name { get; }
        void EnrollStudent(Student student);
        IEnumerable<Student> GetEnrolledStudents();
    }

    interface IStudentService : IPersonService
    {
        void EnrollInCourse(string CourseName, char grade);
        double CalculateGPA();
    }

    interface IInstructorService : IPersonService
    {
        int YearsOfExperience(DateTime JoinedDate);
        decimal CalculateSalary();
        string Department { get; set; }
        bool IsHead { get; set; }
    }

    interface IDepartmentService 
    {
        Instructor HeadInstructor {  get; set; }
        decimal Budget { get; set; }
        IEnumerable<Course> GetCourses();
    }


    //class Program
    //{
    //    static void Main()
    //    {
            
    //        Instructor headInstructor = new("John", new DateTime(1980, 5, 15), "Computer Science", new DateTime(2010, 8, 1))
    //        {
    //            Salary = 5000,
    //            IsHead = true
    //        };
    //        Department csDepartment = new("Computer Science", headInstructor, 100000);

           
    //        Course algorithms = new("Algorithms");
    //        csDepartment.OfferCourse(algorithms);

            
    //        Student student1 = new("Jane", new DateTime(2002, 3, 10));
    //        student1.EnrollInCourse("Algorithms", 'A');
    //        algorithms.EnrollStudent(student1);

            
    //        Console.WriteLine($"Department: {csDepartment.Name}");
    //        Console.WriteLine($"Head: {csDepartment.HeadInstructor.Name}");
    //        Console.WriteLine($"Budget: {csDepartment.Budget}");
    //        Console.WriteLine($"Courses Offered: {string.Join(", ", csDepartment.GetCourses().Select(c => c._name))}");
    //        Console.WriteLine($"Student GPA: {student1.CalculateGPA()}");
    //    }
    }





}
