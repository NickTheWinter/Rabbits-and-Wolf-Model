using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolfsAndRabbits
{
    internal class Program
    {
        public static double rabbits = 500;
        public static double wolfs = 5;
        public static double alpha = 0.1;
        public static double beta = 0.01;
        public static double gamma = 0.06;
        public static double delta = 0.0001;
        static void Main(string[] args)
        {
            
            Console.WriteLine("1 год. Кроликов {0} . Волков {1}",rabbits,wolfs);
            for (int i = 2; i <= 217; i++)
            {
                Console.WriteLine("{0} год. Кроликов {1} . Волков {2}",i, Math.Round(RabbitsReproduction(rabbits),0), Math.Round(WolfsReproduction(wolfs),0));
            }
            Console.ReadLine();
        }

        static double RabbitsReproduction(double number)
        {

            number = rabbits + alpha*rabbits-beta*rabbits*wolfs;
            rabbits = number;
            return number;
        }

        static double WolfsReproduction(double number)
        {
            number = wolfs - gamma * wolfs + delta * rabbits * wolfs;
            wolfs = number;
            return number;
        }
    }
}
