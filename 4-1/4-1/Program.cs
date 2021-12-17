using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] week = { "Lundi", "Mardi", "Mercredi", "Jedi", "Vendredi", "Samedi" };
            // indices 1 et 4, puis 1er et 4e elements
            Console.WriteLine(week[1]);
            Console.WriteLine(week[4]);
            Console.WriteLine(week[0]);
            Console.WriteLine(week[3]);
            //correction du 4e jour
            week[3] = "Jeudi";
            Array.Resize(ref week, 7);
            week[6] = "Dimanche";
            //affichage de week entier
            foreach(string day in week)
            {
                Console.WriteLine(day);
            }
        }
    }
}
