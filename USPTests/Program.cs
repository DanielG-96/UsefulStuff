using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsefulStuffPortable.Utilities;
using UsefulStuffPortable.Extensions;

namespace USPTests
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>
            {
                "Apple",
                "Orange",
                "Lemon"
            };

            Console.WriteLine("Old list: ");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            list.ReplaceAt("Apple", "Pear");

            Console.WriteLine("New list: ");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
