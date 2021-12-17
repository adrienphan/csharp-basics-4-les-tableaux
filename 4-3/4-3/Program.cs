using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 32, 25, 6, 17 };
            int result = 0;
            foreach(int a in numbers)
            {
                result += a;
            }
            Console.WriteLine("total de l'opération : " + String.Join(" + ", numbers) + " = " + result);
            Console.ReadLine();
        }
    }
}
