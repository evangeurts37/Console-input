using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_input
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;


            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            age = Convert.ToInt32(Console.ReadLine());


            DateTime years = DateTime.Today;




            Console.WriteLine($"your name is {name} and you were born in {age} years old, the current year is {years.ToString("yyyy")}");


            years = 
            
        }
    }
}
