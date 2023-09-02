using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_activity_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int salary, counter, avarage,sum;
            counter = 1;avarage = 0;sum = 0;
            while (counter <= 10) 
            {
                Console.WriteLine("Enter your Salary amount :");
                salary = Convert.ToInt32((Console.ReadLine()));
                sum = sum + salary;
                avarage = sum / counter;
                counter++;

            }
            Console.WriteLine("Avarage Salary of an employee :" + avarage);



            Console.ReadLine();







        }
    }
}
