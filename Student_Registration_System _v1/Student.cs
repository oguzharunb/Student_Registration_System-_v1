using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Registration_System__v1
{
    class Student
    {
        public int StudNumber;
        public string StudFirstName;
        public string StudLastName;
        public BRANCH Branch;

        public Student(int studnumber , string firstname, string lastname, BRANCH branch)
        {
            StudNumber = studnumber;
            StudFirstName = firstname;
            StudLastName = lastname;
            Branch = branch;
        }
    }

    enum BRANCH
    {
        Null,
        Math,
        Science,
        Language,
        History
    }
}
