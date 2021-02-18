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


            DateTime date = DateTime.Today;




            Console.WriteLine($"Hello {name} and you were born in {date.Year - age} , the current year is {date.Year}");


            


            Console.ReadLine();
            
        }
    }
}
