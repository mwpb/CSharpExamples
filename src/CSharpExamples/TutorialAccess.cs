using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorials
{
    public class TutorialAccess
    {
        public class Person
        {
            protected string FirstName { get; private set; }
            protected string LastName { get; private set; }
            public DateTime DateOfBirth { get; set; }
            protected string FullName { get; set; }
            public bool IsAnAdult()
            {
                var eighteenYearAgo = DateTime.Today.AddYears(-18);
                return this.DateOfBirth < eighteenYearAgo;
            }
            public Person(string firstName, string lastName, DateTime dateOfBirth)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.DateOfBirth = dateOfBirth;
            }
        }

        public class Student:Person
        {
            public Student(string firstName, string lastName, DateTime dateOfBirth)
                :base(firstName, lastName, dateOfBirth)
            {

            }
            private string SchoolName { get; set; }
            public string RosterName { get { return $"{this.LastName}, {this.FirstName}"; } }
        }

        public class Course
        {
            public string Name { get; set; }
            public List<Student> EnrolledStudents { get; set; }
            public Course()
            {
                Name = "The First Course";
                var John = new Student("John","Doe",new DateTime(2016,11,11));
                var Jane = new Student("Jane", "Doe", new DateTime(2016, 11, 11));
                EnrolledStudents = new List<Student>() { John, Jane };

            }
            public void printStudents()
            {
                foreach (Student student in EnrolledStudents)
                {
                    Console.WriteLine(student.RosterName);
                }
            }
        }
        public Course createCourse()
        {
            return new Course();
        }
    }
}
