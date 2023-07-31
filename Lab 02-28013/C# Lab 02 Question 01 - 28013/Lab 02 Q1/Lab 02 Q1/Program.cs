using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1,num2,sum;

            Console.WriteLine("Enter 1st number: ");
            num1=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd number: ");
            num2=int.Parse(Console.ReadLine()); 

            sum=num1 + num2;
            Console.WriteLine("The sum of 1st and 2nd numbers is: " +sum);

            Console.ReadLine();



        }
    }
}
