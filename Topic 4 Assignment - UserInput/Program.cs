using System;

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
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //----------------------------------------
            Console.WriteLine("==========================");
            string name2;
            int age2;
            Console.WriteLine(" Hi whats your name? ");
            name2 = Console.ReadLine();
            Console.WriteLine(" hi " + name2 + " how old are you? ");
            age2 = Convert.ToInt32(Console.ReadLine());
            age2 = age2 + 5;
            Console.WriteLine(" wow that old but if you added 5 years then you'd be " + age2);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //----------------------------------------
            Console.WriteLine("==========================");
            double num1, num2, num3, calculatedNum;
            Console.WriteLine("Hello user, please enter your first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hello user, please enter your second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hello user, please enter your third number: ");
            num3 = Convert.ToDouble(Console.ReadLine());
            calculatedNum = num1 + num2 + num3 / 2;
            Console.WriteLine("Congrats your number is now: " + calculatedNum);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //----------------------------------------
            Console.WriteLine("==========================");
            double price1, price2, firstTotal, discount, finalPrice;
            string item1, item2;
            Console.WriteLine("Hello, please enter your first item: ");
            item1 = Console.ReadLine();
            Console.WriteLine("Great, please enter the price of that item: ");
            price1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now please enter your second item: ");
            item2 = Console.ReadLine();
            Console.WriteLine("Good choice, please enter the price of that item: ");
            price2 = Convert.ToDouble(Console.ReadLine());
            firstTotal = price1 + price2;
            Console.WriteLine("your total is ");
            Console.WriteLine(item1 + " = " + price1.ToString("C"));
            Console.WriteLine(item2 + " = " + price2.ToString("C"));
            Console.WriteLine("Total = " + firstTotal.ToString("C"));
            discount = firstTotal / 20;
            Console.WriteLine("20% discount = " + discount);
            finalPrice = discount * 1.3;
            Console.WriteLine("However with tax your final price is = " + finalPrice);
        }
    }
}
