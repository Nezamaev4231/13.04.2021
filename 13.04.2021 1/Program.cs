using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._04._2021_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Незамаев
            Console.WriteLine("Введите число a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число a");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число c");
            double c = Convert.ToDouble(Console.ReadLine());
            if ((a < b + c) & (b < a + c) & (c < a + b))
            {
             Console.WriteLine("Треуг.не сущ.");
            }
            else
            {
                Console.WriteLine("Треуг.не сущ.");
            } 
             Console.ReadKey(); 


        }
    }
}
