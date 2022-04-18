using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    class Group
    {
        public string No;
        public Category Category;
        public bool Isonline;
        public int Limit;
        private static int Bp = 200;
        private static int Bn = 200;
        private static int Dn = 200;
        public  List<Student> students;
        public static List<Group> groups = new List<Group>() { };
        public Group(Category categories, bool online)
        {
            switch (categories)
            {
                case Category.Programming:
                    No = $"BP{Bp++}";
                    break;
                case Category.SystemAdminstration:
                    No = $"BN{Bn++}";
                    break;
                case Category.Design:
                    No = $"DN{Dn++}";
                    break;
                default:
                    Console.WriteLine("Bele bir qrup adi yoxdur");
                    return;
            }
            Category = categories;
            if (online==true||online==false)
            {
                Isonline = online;
            }
            else
            {
                Console.WriteLine("Duzgun sechim edin true or false");
                return;
            }
            if (online==true)
            {
                Limit = 15;
                students = new List<Student>(Limit);
            }
            else
            {
                Limit = 10;
                students = new List<Student>(Limit);
            }
        }
        public void AddStudent(Student student)
        {
            if (students.Count<Limit)
            {
                students.Add(student);
            }
            else
            {
                Console.WriteLine("Limiti ashirsiz");
            }
            if (student.GroupNo == default)
            {
                student.GroupNo = No;
            }
            else
            {
                throw new Exception("Bu telebe hal-hazirda basqa bir qrupdadir");
            }

        }

        internal void AddStudent(object student)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            var onlineO = Isonline ? "Online" : "Offline";
            string catO;
            if (Category == Category.Programming)
            {
                catO = "Programming";
            }
            else if (Category == Category.Design)
            {
                catO = "Design";
            }
            else
            {
                catO = "System";
            }
            return $"\nAdi:{No}\nCategory: {catO}\nOnline Status: {onlineO}\n";
        }



    }

}

