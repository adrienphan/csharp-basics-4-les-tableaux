using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_6
{
    internal class Program
    {
        enum week { 
        Lundi,
        Mardi,
        Mercredi,
        Jeudi,
        Vendredi,
        Samedi,
        Dimanche
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine((week)i);
            }
            Console.WriteLine((week)4);
            Console.ReadLine();
        }
    }
}
