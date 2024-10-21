namespace abd
{
    class Program
    {
        static List<student> listname = new List<student>();
        static List<teacher> list = new List<teacher>();
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("1. Add Students\n 2. show Students \n 3.Add Teacher\n 4.Show teacher \n 5.Show Teacher");
                int userinput = Convert.ToInt32(Console.ReadLine());

                if (userinput == 1)
                {
                    student.Addstudent();
                }
                else if (userinput == 2)
                {
                    student.Showstudent();
                }
                else if (userinput == 3)
                {
                    teacher.Addteacher();
                }
                else if (userinput == 4)
                {
                    teacher.Showteacher();
                }
                else if (userinput == 5)
                {
                    student.Showstudent();
                    teacher.Showteacher();
                }
                else
                {
                    Console.WriteLine("No data found");
                }

            }
        }

        class student
        {
            public int id { get; set; }
            public string name { get; set; }


            public static void Addstudent()
            {

                student aptech = new student();

                Console.WriteLine("Enter id");
                aptech.id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Name");
                aptech.name = Console.ReadLine();

                listname.Add(aptech);
            }
            public static void Showstudent()
            {
                foreach (student name in listname)
                {
                    Console.WriteLine($"Student Id is {name.id} \n Student Name is {name.name}");
                }
                if (listname.Count < 1)
                {
                    Console.WriteLine("No students found");
                }
            }
        }


        class teacher
        {
            public int id { get; set; }
            public string name { get; set; }


            public static void Addteacher()
            {

                teacher tech = new teacher();

                Console.WriteLine("Enter id");
                tech.id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Name");
                tech.name = Console.ReadLine();

                list.Add(tech);
            }
            public static void Showteacher()
            {
                foreach (teacher name in list)
                {
                    Console.WriteLine($" Teacher Id is {name.id} \n Teacher Name is {name.name}");
                }
            }
        }

    }

}
