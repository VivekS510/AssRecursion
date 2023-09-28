using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssRecursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Find number of digits in given number

            int number, count = 0;
            Console.WriteLine("Write a number : ");
            number = Convert.ToInt32(Console.ReadLine());
            while(number>0)
            {
                digit();
            }
            void digit()
            {
                number = number / 10;
                count++;
            }
            Console.WriteLine("total digits in given number : " +count);
            
            // Find factorial of the number we get as digits

            Console.WriteLine("Now we are getting factorial of this :::: ");
            Console.ReadLine();
            int fac = 1;
            
            while(count>0)
            {
                fact();
            }
            void fact() 
            {
                fac *= count;
                count--;
            }
            Console.WriteLine("Factorial of number of digits : " +fac);
            Console.ReadLine();

            // Print even and odd numbers in given range

            int start, end;
            Console.WriteLine("Enter starting point :");
            start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ending point :");
            end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Odd number between given range: ");
            int od = start;
            while(od<=end)
            {
                odd();
            }
            void odd()
            {
                if(od % 2 != 0)
                {
                    Console.WriteLine("  " +od);
                    Console.ReadLine();
                }
                od++;
            }
            Console.ReadLine() ;
            Console.WriteLine("Even number between given range: ");
            int eve = start;
            while (eve <= end)
            {
                even();
            }
            void even()
            {
                if (eve % 2 == 0)
                {
                    Console.WriteLine("  " +eve);
                    Console.ReadLine();
                }
                eve++;
            }
            Console.ReadLine();


        }
    }
}
