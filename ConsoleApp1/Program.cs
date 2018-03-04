using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            var number = Convert.ToInt32(Console.ReadLine());
            if (number == 1)
                Console.WriteLine("Sunday");
            else if (number == 2)
                Console.WriteLine("Monday");
            else if (number == 3)
                Console.WriteLine("Tuesday");
            else if (number == 4)
                Console.WriteLine("Wednesday");
            else if (number == 5)
                Console.WriteLine("Thursday");
            else if (number == 6)
                Console.WriteLine("Friday");
            else if (number == 7)
                Console.WriteLine("Saturday");
            else Console.WriteLine("Enter correct number plz !!!");
            Console.ReadKey();
        }
    }
}
