using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function
{
     class Test
    {
        static void Main(string[] args)
        {
            
            int a, b, c;

            Console.WriteLine("Вводите данный a: ");

            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Вводите данный b: ");

            b = int.Parse(Console.ReadLine());
            c = a + b;
            Console.WriteLine("total : " + c);
        }
    }
}
