using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// The source of the exercises which is solved, will be displayed here:https://www.w3resource.com/csharp-exercises/basic-algo/index.php
//First Exercice:. Write a C# Sharp program to compute the sum of the two given integer values. If the two values are the same, then return triple their sum.
namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calling the Function Sum, int the main//
            int CallSum = Sum();

        }
        //Creation of the Function---Sum--- which will give us, the sum of two integers
        static int Sum()
        {
            Console.WriteLine("Give me the First Integer");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give me the Second Integer");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a != b)
            {
                Console.WriteLine("The sum of the two integers is:\n" + (a + b));
                return (a + b);
            }
            else
            {
                int TripleSum = (a + b) * 3;
                Console.WriteLine("Because the two integers where equal, the result of the sum,was tripled\n" + TripleSum);
                return TripleSum;
            }
        }
    }
}







    

