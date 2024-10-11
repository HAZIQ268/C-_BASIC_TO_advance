namespace my_app {

    class program { 
    static void Main() {


            Console.WriteLine("Enter Your Id");
            // Convert integer variable to string
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            // First Method interpulation
            Console.WriteLine($"id is : {id} \n name is : {name}");
            // Second method concatenate method 
            Console.WriteLine("id is :" + id + "\n" + "name is :" + name);
        }
    }

}