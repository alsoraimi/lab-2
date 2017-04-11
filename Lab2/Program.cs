using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a integer between 1 and 100");

            int Num;
            Num = int.Parse(Console.ReadLine());          // user input

            if (Num % 2 != 0 && Num > 60) 


            {

                Console.WriteLine(Num);
                Console.WriteLine("ODD");
            }

          if (Num <= 25 && Num >= 2 && Num % 2 == 0) 

            {

                Console.WriteLine("Even and less than 25");
            }

            if (Num % 2 == 0 && Num > 60)
            {
                Console.WriteLine(Num);
                Console.WriteLine("EVEN");

            }
            
            




        }
    }
}
