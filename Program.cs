using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
              int Aprice, Sprice, Profit,Loss;

            Console.WriteLine(" Enter actual Price: ");
              Aprice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter Selling Price: ");
              Sprice = Convert.ToInt32(Console.ReadLine());

            if (Sprice > Aprice)
            {
                Profit = Sprice - Aprice;
                Console.Write("Profit");
            }
            else (Aprice > Sprice)
            {
                Loss = Aprice - Sprice;
                Console.Write("Loss");
            }
        }
    }
}
