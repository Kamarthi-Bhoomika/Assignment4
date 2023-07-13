using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            int num = int.Parse(Console.ReadLine());

            if(num>0)
            {
                Console.WriteLine("The Number is Positive");
            } else if(num == 0)
            {
                Console.WriteLine("The Number is Zero");
            } else 
            { 
                Console.WriteLine("The Number is Negative"); 
            }
            if(num % 2 == 0)
            {
                Console.WriteLine("The Number is Even");
            }
            else
            {
                Console.WriteLine("The Number is Odd");
            }
            Console.ReadKey();
        }
    }
}
