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
            #region
            //var names = new List<string>
            //{
            //    "Tokyo","New Delhi","Bangkok","London","Paris","Berlin","Moscow","Warsaw","Hong Kong",
            //};

            //var query = names.Where(s => s.Length <= 5).ToArray();
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("---------");

            //names[0] = "Osaka";
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}
            //IEnumerable<string> query = names.Where(s => s.Length <= 5);
            //foreach (string s in query)
            //{
            //    Console.WriteLine(s);
            //}
            #endregion
            #region
            //var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            //var query = numbers.Exists(s => s % 8 == 0 || s % 9 == 0);
            //    Console.WriteLine(query);
            #endregion
            #region
            //var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            //numbers.ForEach(s => Console.WriteLine(s / 2));
            #endregion
            #region
            //var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            //IEnumerable<int> query = numbers.Where(s => s > 50);
            //foreach (int s in query)
            //{
            //    Console.WriteLine(s);
            //}
            #endregion
            #region
            //var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            //var query = numbers.Select(s => s * 2).ToList<int>();

            //var list = query;

            //foreach (int s in list)
            //{
            //    Console.WriteLine(s);
            //}
            #endregion
            var names = new List<string>
            {
                "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong", 
            };

            var line = Console.ReadLine();

            var result = names.FindIndex(s => s == line);

            try
            {
                Console.WriteLine(names[result]);
            }
            catch
            {
                Console.WriteLine(-1);
            }
        }
    }
}
