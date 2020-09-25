using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>
            {
                "Tokyo","New Delhi","Bangkok","London","Paris","Berlin","Moscow","Warsaw","Hong Kong",
            };

            var query = names.Where(s => s.Length <= 5).ToArray();
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------");

            names[0] = "Osaka";
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            //IEnumerable<string> query = names.Where(s => s.Length <= 5);
            //foreach (string s in query)
            //{
            //    Console.WriteLine(s);
            //}
        }
    }
}
