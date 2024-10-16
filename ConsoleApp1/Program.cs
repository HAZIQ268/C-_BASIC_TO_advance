namespace my_app {

    class program {

        static List<string> list_name = new List<string>(); 
    static void Main() {
            while (true)
            {
                Console.WriteLine("1.Add Student \n 2.Show Student");
                int user_input = Convert.ToInt32 (Console.ReadLine());

                if (user_input == 1)
                {
                    add_data();
                }
                else
                {
                    show_data();

                }


            }

        }
        static void add_data() { 
                Console.WriteLine("Enter Your Name");
                string name = Console.ReadLine();
                list_name.Add(name);

        }
        static void show_data() {
            foreach (string names in list_name)
            {
                Console.WriteLine($"name is {names}");
            }
        }

    }

}