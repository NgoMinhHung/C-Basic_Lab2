using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            var number = Convert.ToInt32(Console.ReadLine());
            string[] A = {"Sunday"," Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
            if (number > 0 && number < 8)
            {
                for (int i = 1; i < 8; i++)
                {
                    if (number == i) Console.WriteLine(A[i - 1]);

                }
            }
            else Console.WriteLine("Enter correct a number!!!");
            Console.ReadKey();
        }
    }
}
