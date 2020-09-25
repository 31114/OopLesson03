﻿using System;
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

            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            numbers.ForEach(s => Console.WriteLine(s / 2));
        }
    }
}
