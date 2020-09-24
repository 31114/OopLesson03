using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter3
{
    class Program
    {
        public delegate bool Judgement(int value);
        static void Main(string[] args)
        {
            var numbers = new[] { 5, 3, 9, 1, 7, 2, 3, 8, 9, 7, 4, 1, 2, 3, 8, 4, 5 };

            //Judgement judge = IsEven;
            //int count = Count(numbers, delegate(int n)
            //    {
            //        return (n % 2 == 0);
            //    });
            int count = Count(numbers, (int n) => { return (n >= 5); });
            Console.WriteLine($"偶数の数は{count}です");
        }

        //nが偶数かどうかを調べる
        public static bool IsEven(int n )
        {
            //同じらしいよ
            return (n % 2 == 0);
            //if(n % 2 == 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
        public static int Count(int[] numbers, Judgement judge)
        {
            int count = 0;
            foreach (var n in numbers)
            {
                if (judge(n) == true)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
