using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct Calc
    {
        public void Calculate(int f, int s, string op)
        {
            switch (op)
            {
                case "sum":
                    Console.WriteLine($"The result is {f+s}");
                    break;
                case "div":
                    Console.WriteLine($"The result is {f / s}");
                    break;
                case "mul":
                    Console.WriteLine($"The result is {f * s}");
                    break;
                case "sub":
                    Console.WriteLine($"The result is {f - s}");
                    break;
                case "pow":
                    Console.WriteLine($"The result is {Math.Pow(f, s)}");
                    break;
            }
            Console.ReadLine();
        }
    }

    class Program
    {

     static void Main(string []args)
        {
            Console.WriteLine("Choose the operation: \n(hint: sum,sub,div,mul or pow)");
            string op = Console.ReadLine();
            if (op =="pow")
            {
                Console.WriteLine("X^y, where X - first var, y - second\n");
            }
            Console.WriteLine("First variable: ");
            var first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second variable: ");
            var second = Convert.ToInt32(Console.ReadLine());
            Calc calculator = new Calc();
            calculator.Calculate(first, second, op);

        }       
    }
}
