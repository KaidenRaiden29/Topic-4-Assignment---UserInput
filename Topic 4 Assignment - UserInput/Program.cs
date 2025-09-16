namespace Topic_4_Assignment___UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, login;
            int age, Grade, ID;
            double salary;
            
            Console.WriteLine("Hello, Whats your name?: ");
            name = Console.ReadLine();
            Console.WriteLine(" Woah thats a neat name " + name + " How old are you?: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(age + " nice! how much do you make?: ");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(salary + " wow thats alot, now please fill out this info :D ");
            Console.WriteLine("whats your grade?: ");
            Grade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("whats your Student ID?: ");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("whats your Login?: ");
            login = Console.ReadLine();

            //----------------------------------------


        }
    }
}
