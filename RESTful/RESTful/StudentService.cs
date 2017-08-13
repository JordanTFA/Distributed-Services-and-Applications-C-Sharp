using System;
using System.ServiceModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTful
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    class StudentService : IStudentService
    {
        // Dictionary (collection of all the students currently in the system)
        private Dictionary<string, Student> students = new Dictionary<string, Student>();

        // Next available index to add to the collection
        private int index = 9000000;

        public StudentService()
        {
            // Add a dummy student to the collection
            Student student = new Student();
            student.matric = "010101";
            student.firstName = "Bob";
            student.lastName = "Bobson";
            student.programme = "BEng Computing";
            students.Add(student.matric, student);
        }

        public StudentList GetStudents()
        {
            // Return all the students from dictionary
            StudentList list = new StudentList();
            list.AddRange(students.Values);
            return list;
        }

        public Student GetStudent(string matric)
        {
            // Get a particular student from the dictionary
            return students[matric];
        }

        public Student PostStudent(Student student)
        {
            // Add the student to the dictionary
            // Create the matriculation number string
            string matric = "0" + index;

            // Check the matric number doesn't already exist
            while (students.ContainsKey(matric))
            {
                // Matriculation number exists. Generate new one
                ++index;
                matric = "0" + index;
            }

            // Set the matriculation number with the student
            student.matric = matric;

            // Add the student to the Dictionary
            students.Add(matric, student);

            // Return the student with the Matric number added
            return student;
        }
    }
}
