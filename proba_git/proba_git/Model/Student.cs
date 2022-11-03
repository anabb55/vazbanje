using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba_git.Model
{
    internal class Student
    {
        public int Name { get; set; }
        public string Surname { get; set; }
        public int JMBG { get; set; }
        public List<int> grades { get; set; }


        public Student()
        {

        }

        public void printAllGrades(Student student) {
            foreach (int grade in student.grades) {
                Console.WriteLine(grade);
            }

        }


    }
}
