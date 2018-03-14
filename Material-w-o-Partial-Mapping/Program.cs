using Material_w_o_Partial_Mapping.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Material_w_o_Partial_Mapping
{
    class Program
    {
        static void Main(string[] args)
        {
            Buyers buyer = new Buyers();
            List<Buyer> buyers = buyer.InitializeBuyers();
            int materialUnits;
            Console.WriteLine(System.Configuration.ConfigurationManager.AppSettings["unitsMaterialMsg"]);
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out materialUnits))
                {
                    Console.WriteLine(System.Configuration.ConfigurationManager.AppSettings["repeatUnitsMaterialMsg"]);
                    continue;
                }

                if (materialUnits > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(System.Configuration.ConfigurationManager.AppSettings["repeatUnitsMaterialMsg"]);
                }

            }
            buyer.ComputeBuyers(buyers, materialUnits);
            Console.ReadKey();
        }
    }
}
