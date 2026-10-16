using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_in_clas_part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: "); 
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
           double b = double.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            double c = double.Parse(Console.ReadLine());

            double average = (a + b + c) / 3;
            Console.WriteLine("The average of the three numbers is: " + average);

        }
    }
}
