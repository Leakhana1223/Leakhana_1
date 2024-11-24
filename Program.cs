using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Label1:
            int num1,num2,num3;
            Console.Write("Please enter Num1:");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter Num2:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please selete a mothed :");
            Console.WriteLine("1 – Summary:");
            Console.WriteLine("2 – Multiply:");
            Console.WriteLine("3 – Minus:");
            int choose;
            Console.Write("please enter Number :");
            choose = Convert.ToInt32(Console.ReadLine());
            float resuft = 0f;
            switch (choose)
            {
                case 1:
                    resuft=num1+num2;
                    Console.Write($"Summary Number{num1} and {num2} is :{resuft}");
                    break;
                case 2:
                    resuft = num1 * num2;
                    Console.Write($"Multiply Number{num1} and {num2} is :{resuft}");
                    break;
                case 3:
                    resuft = num1 - num2;
                    Console.Write($"Minus Number{num1} and {num2} is :{resuft}");
                    break;
            }
            Console.WriteLine();
            goto Label1;
            

        }
    }
}
