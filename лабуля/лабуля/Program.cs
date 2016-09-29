using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лабуля
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Привет мир!");
            int a = 5;
            int b = 2;
            System.Console.WriteLine("a =  " + a + ", b = " + b);

            int result = a + b;
            System.Console.WriteLine("Сложение, a + b =  " + result);
            result = a * b;
            System.Console.WriteLine("Умножение, a * b =  " + result);
            result = a / b;
            System.Console.WriteLine("Деление, a / b =  " + result + " a и  b - целые числа, деление только нацело");
            System.Console.ReadLine();

        }
    }
}
