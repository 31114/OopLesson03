using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4-2-1
            var ymCollection = new YearMonth[]
            {
                new YearMonth(1917 ,5),
                new YearMonth(1917 ,11),
                new YearMonth(1921 ,1),
                new YearMonth(1939 ,12),
                new YearMonth(1945 ,7),
                new YearMonth(1991 ,12),
            };

            //4-2-2
            foreach (var ym in ymCollection)
            {
                Console.WriteLine(ym); ;
            }

            //4-2-4
            Console.WriteLine("4-2-4");
        }
        //4-2-3
        static YearMonth Find21c(YearMonth[] yms)
        {
            foreach(var ym in yms)
            {
                if (ym.Is21Century)
                    return ym;
            }
            return null;
        }
    }

    #region
    //    static void Main(string[] args)
    //    {

    //    }
    //    #region
    //    //    string code = "1234";

    //    //    var message = GetMessage(code) ?? DefaultMessage();
    //    //    Console.WriteLine(message);
    //    //}

    //    //private static object DefaultMessage()
    //    //{
    //    //    return "DefaultMessage";
    //    //}
    //    //private static object GetMessage(string code)
    //    //{
    //    //    return 123;
    //    //}
    //    #endregion

    //    private static string GEtProduct()
    //    {
    //        Sale sale = new Sale
    //        {
    //            ShopName = "PET Store",
    //            Amount = 1000,
    //            Product = "Computer"
    //        };
    //        sale = null;
    //        return sale?.Product;
    //    }
    //}
    //    class Sale
    //    {
    //        public string ShopName { get; set; }
    //        public int Amount { get; set; }
    //        public string Product { get => product; set => product = value; }

    //        private string product;
    //}
    #endregion
}
