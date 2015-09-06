using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace In91Day1Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new Products();

            var result1 = products.GetSum(3, "Cost");

            Console.WriteLine(string.Join(",", result1.ToArray()));

            var result2 = products.GetSum(4, "Revenue");

            Console.WriteLine(string.Join(",", result2.ToArray()));

            Console.ReadKey();

        }
    }
}
