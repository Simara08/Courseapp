using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    class Student
    {
        public string FullName;
        public string GroupNo;
        public bool Type;
        public Student(string fullName, bool type)
        {
            FullName = fullName;
            Type = type;
        }
        public static List<Student> AllStudents = new List<Student>() { };
        public override string ToString()
        {
            var typeO = Type ? "Zemanetli" : "Zemanetsiz";
            return $"\nName:{FullName}\nGroupNo: {GroupNo}\nType: {typeO}\n";
        }
    }
}
