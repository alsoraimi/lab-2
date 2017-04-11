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
            Console.WriteLine("Please enter your first name");
            string Name;
            Name = Console.ReadLine();


            Console.WriteLine("Hello {0}, Please enter a integer between 1 and 100", Name);

            int Num;
            Num = int.Parse(Console.ReadLine());          // user input

            if (Num % 2 != 0 && Num > 60) 


            {

                Console.WriteLine(Num);
                Console.WriteLine("Your number is ODD, {0}", Name);
            }

          if (Num <= 25 && Num >= 2 && Num % 2 == 0) 

            {

                Console.WriteLine("Your number is EVEN and less than 25, {0}", Name);
            }

            if (Num % 2 == 0 && Num > 60)
            {
                Console.WriteLine(Num);
                Console.WriteLine("your number is EVEN, {0}" , Name);

            }
            
            




        }
    }
}
