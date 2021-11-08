using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Student_Registration_System__v1
{
    class School
    {

        public List<Student> Students = new List<Student>();

        public void RegisterStudent(int studnumber, string firstname, string lastname, BRANCH branch)
        {
            Students.Add(new Student(studnumber, firstname, lastname,branch));
        }


    }
}
