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

            int Num1;
            int Num2;
            int Num3;

            double km1;
            double km2;
            double km3;

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            age = Convert.ToInt32(Console.ReadLine());


            DateTime date = DateTime.Today;




            Console.WriteLine($"Hello {name} and you were born in {date.Year - age} , the current year is {date.Year}");

            Console.WriteLine("______________________________________________________________________________________________");

            Console.WriteLine("Give me 3 numbers.");
            Console.WriteLine("1.");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3.");
            Num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The 3 numers total is {Num1 + Num2 + Num3}");
            Console.WriteLine("_______________________________________________________________________________________________");
            Console.WriteLine("Give me 3 distances in Km");
            Console.WriteLine("1.");
            km1 = (double)Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("2.");
            km2 = (double)Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("3.");
            km3 = (double)Convert.ToDecimal(Console.ReadLine());
            double average = (km1 + km2 + km3) / 3;
            
            Console.WriteLine($"The average distance is {Math.Round((double)average,2)} Km");
           


            Console.ReadLine();

        }
    }
}

