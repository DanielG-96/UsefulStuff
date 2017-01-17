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
            Console.WriteLine("Current time is: " + DateTime.UtcNow);
            DateTime earlierTime = DateTime.UtcNow.Subtract(new TimeSpan(0, 0, 1, 30));
            Console.WriteLine(earlierTime);
            Console.WriteLine(earlierTime.ToPrettyDate());

            Console.WriteLine(Utilities.SizeSuffix(100005000L));

            Console.WriteLine(Utilities.GetRandomLetter(true));

            Console.ReadLine();
        }
    }
}
