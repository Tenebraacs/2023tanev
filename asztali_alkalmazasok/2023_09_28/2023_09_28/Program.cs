using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_09_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem, adja meg a pont x koordinátáját: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Kérem, adja meg a pont y koordinátáját: ");
            double y = Convert.ToDouble(Console.ReadLine());

            string negyed;

            if (x > 0 && y > 0)
                negyed = "I. síknegyed";
            else if (x < 0 && y > 0)
                negyed = "II. síknegyed";
            else if (x < 0 && y < 0)
                negyed = "III. síknegyed";
            else if (x > 0 && y < 0)
                negyed = "IV. síknegyed";
            else if (x == 0 && y == 0)
                negyed = "A pont a koordinátatörzsnél van";
            else
                negyed = "A pont a tengelyeken vagy a tengelyek között van";

            Console.WriteLine($"A pont a(z) {negyed}-ben van.");
        }
    }
}
