using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string yesNo = "o";
            List<int> numbers = new List<int> {1};
            int result = 1;
            string allNumbers = "";
            while (yesNo == "o")
            {
                Console.WriteLine("entrez un nombre à multiplier");
                numbers.Add(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("souhaitez vous ajouter un nouveau nombre ?(o/n)");
                yesNo = Console.ReadLine();
            }
            foreach (int a in numbers)
            {
                result *= a;
                allNumbers += " " + a;
            }
            Console.WriteLine("Produit : " + result + "\n les nombres etaient :" + allNumbers);
        }
    }
}
