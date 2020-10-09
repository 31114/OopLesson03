using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5-1
            Console.WriteLine("5-1 : 文字列を2つ入力");
            var Word1 = Console.ReadLine();
            var Word2 = Console.ReadLine();
            if(String.Compare(Word1,Word2,true) == 0)
                Console.WriteLine("Same");
            else
                Console.WriteLine("Different");

            //5-2
            var Word3 = Console.ReadLine();
            int num;
            if (int.TryParse(Word3, out num))
            {
                Console.WriteLine(num);
            }

            //5-3
            //1

            var Word = "Jackdaws love my big sphinx of quartz";

            Console.WriteLine($"スペースの数は{Word.Count(s => s == (' '))}");

            //2
            var replace = Word.Replace("big", "small");
            Console.WriteLine(replace);

            //3
            int count = Word.Split(' ').Count();
            Console.WriteLine("単語数:{0}",count);

            //4
            var less4 = Word.Split(' ').Where(s => s.Length <= 4);
            foreach (var item in less4)
            {
                Console.WriteLine(item);
            }

            //5
            var array = Word.Split(' ').ToArray();
            if (array.Length > 0)
            {
                var sb = new StringBuilder();
                foreach (var item in array)
                {
                    sb.Append(item);
                    sb.Append(' ');
                }
            Console.WriteLine(sb);
            }

            //5-4
            var kwmn = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";

            var head = kwmn.Split(';');
            foreach (var item in kwmn)
            {
                var meat = head[0].Split('=');
            }
        }
    }
}
