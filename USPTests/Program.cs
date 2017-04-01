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
            Console.WriteLine("Current time is: " + DateTime.Now);
            DateTime earlierTime = DateTime.Now.Subtract(new TimeSpan(0, 0, 1, 30));
            Console.WriteLine(earlierTime);
            Console.WriteLine(earlierTime.ToPrettyDate());

            Console.WriteLine(Utilities.SizeSuffix(100005000L));

            Console.WriteLine(Utilities.GetRandomLetter(true));

            bool isWeekend = DateTime.Now.IsWeekend();

            if (isWeekend)
                Console.WriteLine("Today is a weekend");
            else
                Console.WriteLine("Today is NOT a weekend");

            Console.ReadLine();
        }
    }
}
