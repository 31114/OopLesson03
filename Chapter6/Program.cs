using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6
{
    class Program
    {
        static void Main(string[] args)
        {
            //var numbers = new List<int>
            //{ 17, 38, 26, 50, 37, 15, 62, 37, 83, 47, 15, 35};

            //numbers.Select(n => n.ToString("0000")).ToArray().ForEach(sbyt => Console.WriteLine(s + "");


            //var words = new List<string>
            //{
            //    "Microsoft",
            //    "IBM",
            //    "Commodore",
            //    "Radioshack",
            //    "Sinclair",
            //    "ATARI",
            //};

            //var lower = words.Select(name => name.ToLower()).ToArray();

            //var books = Books.GetBooks();
            //var titles = books.Select(name => name.Title);
            //foreach (var title in titles)
            //{
            //    Console.WriteLine(title + " ");
            //}

            //var sortedBooks = books.OrderByDescending(book => book.Pages);
            //foreach (var book in sortedBooks)
            //{
            //    Console.WriteLine(book.Title + " " + book.Pages);
            //}

            //6-1
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            //1
            Console.WriteLine("----@ Q_6-1-1 @----");

            Console.WriteLine(numbers.Max());

            //2
            Console.WriteLine("----@ Q_6-1-2 @----");
            var pos = numbers.Length - 2;
            var shqip = numbers.Skip(pos);
            foreach (var num in shqip)
            {
                Console.WriteLine(num + "");
            }

            //3

            Console.WriteLine("----@ Q_6-1-3 @----");

            var str = numbers.Select(n => n);
            foreach (var num in str)
            {
                Console.WriteLine(num.ToString());
            }

            //4
            Console.WriteLine("----@ Q_6-1-4 @----");

            var descent = numbers.OrderBy(n => n).Take(3);

            foreach (var item in descent)
            {
                Console.WriteLine(item);
            }

            //5
            Console.WriteLine("----@ Q_6-1-5 @----");

            var Over10 = numbers.Where(n => n >= 10).Distinct();

            foreach (var item in Over10)
            {
                Console.WriteLine(item);
            }

            //6-2

            var books = new List<Book> {
                new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
                new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
                new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
                new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
                new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
                new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
                new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            };

            //1
            Console.WriteLine("----@ Q_6-2-1 @----");

            var tites = books.Where(n => n.Title == "ワンダフル・C#ライフ").Select(n => "価格" + n.Price + " : ページ数" + n.Pages);

            foreach (var item in tites)
            {
                Console.WriteLine(item);
            }

            //2
            Console.WriteLine("----@ Q_6-2-2 @----");

            var sharp = books.Where(n => n.Title.Contains("C#"));

            foreach (var item in sharp)
            {
                Console.WriteLine(item.Title);

            }
        }
    }
}
