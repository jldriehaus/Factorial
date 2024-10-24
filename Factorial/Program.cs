/*
* Name: Jack Driehaus
* email:  driehajl@mail.uc.edu
* Assignment Number: Assignment in class 10/24/24
* Due Date:   10/24/24
* Course #/Section:   IS3050-001
* Semester/Year:   Fall 2024
* Brief Description of the assignment:  Create a factorial calculator 

* Brief Description of what this module does. {Do not copy/paste from a previous assignment. Put some thought into this. required}
* Citations:
* Anything else that's relevant:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("factorial is " + ComputeFactorial(4));
        }
        /// <summary>
        /// Factorial calculator
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>

        static int ComputeFactorial(int num)
        {
            int factorial = 1;
            int counter = 1;
            while (counter <= num)
            {
                factorial = factorial*counter;
                counter++;
            }
            return factorial;

        }
    }
}
