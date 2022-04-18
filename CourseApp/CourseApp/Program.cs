using System;

namespace CourseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Telebe Yarat");
            Console.WriteLine("2.Butun Telebeleri goster");
            Console.WriteLine("3.Qrup Yarat");
            Console.WriteLine("4.Butun qruplari goster");
            Console.WriteLine("5.Qrupdaki teleblerin siyahisi");
            Console.WriteLine("6.Qrupda düzeliş etmek");
            Console.WriteLine("0.Dayandir");
            bool Isex = true;
            while (Isex)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        CreateStudent();
                        break;
                    case 2:
                        ShowAllStudents();
                        break;
                    case 3:
                        CreateGroup();
                        break;
                    case 4:
                        ShowAllGroups();
                        break;
                    case 5:
                        ShowStudentsGroup();
                        break;
                    case 6:
                        EditGroup();
                        break;
                    default :
                        break;
                }
            }
        }

        private static void EditGroup()
        {
            throw new NotImplementedException();
        }

        private static void ShowStudentsGroup()
        {
            throw new NotImplementedException();
        }

        private static void ShowAllGroups()
        {
            throw new NotImplementedException();
        }

        static void CreateStudent()
        {
            Console.WriteLine("Telebenin adini daxil edin");
            string fullName = Console.ReadLine().Trim();
            for (int i = 0; i < Student.AllStudents.Count; i++)
            {
                if (Student.AllStudents[i].FullName.Trim() == fullName.Trim())
                {
                    Console.WriteLine("Bele  telebe movcuddur!");
                    return;
                }
            }
            Console.WriteLine("Telebenin zemanetli olub olmamasini daxil edin(true/false):");
            bool type = bool.Parse(Console.ReadLine());
            Student exstudent = new Student(fullName, type);
            Student.AllStudents.Add(exstudent);
           
        }
        static void ShowAllStudents()
        {
            foreach (var item in Student.AllStudents)
            {
                Console.WriteLine(item.ToString());
            }
        }
        static void CreateGroup()
        {
            Console.WriteLine("Qrupun kateqoriyasini daxil edin");
            Console.WriteLine("1.Programming");
            Console.WriteLine("2.Design");
            Console.WriteLine("3.System");
            Category ctg = (Category)int.Parse(Console.ReadLine());
            if ((int)ctg < 0 || (int)ctg > 3)
            {
                Console.WriteLine("Duzgun kateqoriya secin");
                return;
            }
            Console.WriteLine("Online status(true/false):");
            bool isOnline = bool.Parse(Console.ReadLine());
            Group exgroup = new Group(ctg, isOnline);
            Group.groups.Add(exgroup);
            static void AddStudentGroup(Student student)
            {
                Console.WriteLine("Elave etmek istediyin qrupun adini daxil et:");
                string groupInput = Console.ReadLine();

                for (int i = 0; i < Group.groups.Count; i++)
                {
                    if (groupInput == Group.groups[i].No)
                    {
                        Group.groups[i].AddStudent(student);
                    }
                }
            }
            static void EditGroup()
            {
                Console.WriteLine("Duzelis etmek istediyin qrupun adini yaz:");
                string groupInput = Console.ReadLine();
                Console.WriteLine("Duzelis etmek istediyin qrupun adini yaz:");
                string groupInput2 = Console.ReadLine();
                for (int i = 0; i < Group.groups.Count; i++)
                {
                    if (groupInput2 == Group.groups[i].No)
                    {
                        Console.WriteLine("\nBu adda qrup movcuddur, ad deyisdirilmir!\n");
                        return;
                    }
                }

                for (int j = 0; j < Group.groups.Count; j++)
                {
                    if (groupInput == Group.groups[j].No)
                    {
                        Group.groups[j].No = groupInput2;
                    }
                }

            }

            static void ShowAllGroups()
            {
                foreach (var item in Group.groups)
                {
                    Console.WriteLine(item.ToString());
                }
            }

            static void ShowStudentsGroup()
            {
                Console.WriteLine("Axtardigin qrupun adini daxil et:");
                string gInput = Console.ReadLine();

                for (int i = 0; i < Group.groups.Count; i++)
                {
                    if (gInput == Group.groups[i].No)
                    {
                        for (int j = 0; j < Group.groups[i].students.Count; j++)
                        {
                            Console.WriteLine(Group.groups[i].students[j].ToString());
                        }

                    }
                }
                Console.WriteLine("Axtardigin qrupun adini daxil et:");
                string ginput = Console.ReadLine();

                for (int i = 0; i < Group.groups.Count; i++)
                {
                    if (gInput == Group.groups[i].No)
                    {
                        for (int j = 0; j < Group.groups[i].students.Count; j++)
                        {
                            Console.WriteLine(Group.groups[i].students[j].ToString());
                        }

                    }
                }
            }


        }
    }
}
