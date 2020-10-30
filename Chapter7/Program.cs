
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter7
{
    class Program
    {
        #region
        //static void Main(string[] args)
        //{
        #region
        //var lines = File.ReadAllLines("sample.txt");
        //var we = new WordsExtractor(lines);
        //foreach (var word in we.Extract())
        //{
        //    Console.WriteLine(word);
        //}
        #region
        ////var employeeDict = new Dictionary<int, Employee>
        ////{
        ////    {100, new Employee(100, "Van Halen")},
        ////    {112, new Employee(112, "Lemmy kilmister")},
        ////    {125, new Employee(125, "Rob Halford")},
        ////};

        ////foreach (KeyValuePair<int, Employee> item in employeeDict)
        ////{
        ////    Console.WriteLine($"{item.Key} = {item.Value.Name}");
        ////}

        ////Console.WriteLine("---The Id can divided by 2---");
        ////var employees = employeeDict.Where(emp => emp.Value.Id % 2 == 0);
        ////foreach (var item in employees)
        ////{
        ////    Console.WriteLine($"{item.Value.Name}");
        ////}

        ////Console.WriteLine("---Id total number---");
        ////var total = employeeDict.Sum(x => x.Value.Id);
        ////Console.WriteLine("Total is " + total);

        //var employee = new List<Employee>()
        //{
        //    new Employee(100, "Van Halen"),
        //    new Employee(112, "Lemmy kilmister"),
        //    new Employee(125, "Rob Halford"),
        //    new Employee(125, "Ozzy Osbourn"),
        //    new Employee(125, "Haruomi Hosono"),
        //    new Employee(125, "Susumu Hirasawa"),
        //    new Employee(125, "Viktor Tsoi"),
        //    new Employee(125, "Yuri Shevchuk"),
        //};

        //var employeeDict = employee.Where(emp => emp.Id % 2 == 0).ToDictionary(emp => emp.Id);

        //foreach (KeyValuePair<int, Employee> item in employeeDict)
        //{
        //    Console.WriteLine($"{item.Value.Id} {item.Value.Name}");
        //}
        #endregion

        ////var dict = new Dictionary<MonthDay, string>
        ////{
        ////   {new MonthDay(3,5), "珊瑚の日"},
        ////   {new MonthDay(8,4), "箸の日"},
        ////   {new MonthDay(10,3), "登山の日"},
        ////};

        ////var md = new MonthDay(8, 4);
        ////var s = dict[md];
        ////Console.WriteLine(s);
        #endregion

        //    var text = "Cozy lummox gives smart squid who asks for job pen";

        //    Exercise1_1(text); //問題1-1
        //}

        //static void Exercise1_1(string text)
        //{
        //    var dict = new Dictionary<char, int>();
        //    //char ;
        //    foreach (var ch in text.ToUpper())
        //    {
        //        char coke = ch;
        //        if ('A' <= ch && ch <= 'Z')
        //        {
        //            if (dict.ContainsKey(ch))
        //            {
        //                dict[ch] += 1;
        //            }
        //            else
        //            {
        //                dict[ch] = 1;
        //            }
        //        }
        //    }
        //    foreach (var item in dict.OrderBy(x => x.Key))
        //    {
        //        Console.WriteLine($"{item.Key} - {item.Value}");
        //    }
        //}
        #endregion
        static void Main(string[] args)
        {
            // コンストラクタ呼び出し
            var abbrs = new Abbreviations();

            // Addメソッドの呼び出し例
            abbrs.Add("IOC", "国際オリンピック委員会");
            abbrs.Add("NPT", "核兵器不拡散条約");

            //7-2-1
            Console.WriteLine(abbrs.Count);

            //7-2-3
            if (abbrs.Remove("NVA"))
            {
                Console.WriteLine("Succesfully deleted");
            }
            else
            {
                Console.WriteLine("Failed to delete");
            }


            // インデクサの利用例
            var names = new[] { "WHO", "FIFA", "NPT", };
            foreach (var name in names)
            {
                var fullname = abbrs[name];
                if (fullname == null)
                    Console.WriteLine("{0}は見つかりません", name);
                else
                    Console.WriteLine("{0}={1}", name, fullname);
            }
            Console.WriteLine();

            // ToAbbreviationメソッドの利用例
            var japanese = "東南アジア諸国連合";
            var abbreviation = abbrs.ToAbbreviation(japanese);
            if (abbreviation == null)
                Console.WriteLine("{0} は見つかりません", japanese);
            else
                Console.WriteLine("「{0}」の略語は {1} です", japanese, abbreviation);
            Console.WriteLine();

            // FindAllメソッドの利用例
            foreach (var item in abbrs.FindAll("国際"))
            {
                Console.WriteLine("{0}={1}", item.Key, item.Value);
            }
            Console.WriteLine();

        }

    }

}

