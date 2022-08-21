
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void Main()
        {

            Problem1();
            Problem2();
            Problem3();
            Problem4();
        }

        public static void Problem1()
        {
            int[] arr = { 55, 100, 12, 5, 77, -2, 64, -100, 14, -25 };

            var qwery = from i in arr group i by i < 0 into res select res;
            var pos = qwery.AsEnumerable().Where(i => i.Key == false).First().First();
            var pos2 = qwery.AsEnumerable().Where(i => i.Key == true).Last().Last();

            Console.WriteLine("The array change: ");
            foreach(var item in qwery)
            {
                foreach (var elem in item)
                {
                    Console.Write($"{elem}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine(pos);
            Console.WriteLine(pos2);
        }

        public static void Problem2()
        {
            int D = 7;
            List<int> list1 = new List<int> { -10, 21, 46, 9, 10, -33, 77, 965, -80 };

            var result1 = list1.FirstOrDefault(x => (x > 0) && (x % 10 == D));

            Console.WriteLine(result1);
        }
        public static void Problem3()
        {
            try
            {
                string[] str1 = { "It is a long established fact that" +
                        "3af reader will be" +
                        " distracted by the readable" +
                        " content of a page when looking at its layout." +
                        " The point of using Lorem Ipsum is that it has" +
                        " 3 a more-or-less normal distribution" };

                int L = 18;
                IEnumerable<string>? query = from i in str1
                                             where i.Length == L
                                             where Char.IsDigit(i[0]) == true
                                             select i;
                string? str2 = "Not found";
                string? Temp = query.Last() ?? str2;
                Console.WriteLine(Temp);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        public static void Problem4()
        {
            int[] arr = { 11, 104, -2, 14, 77, 21, -5, 1, -122, 46, 82, -44 };
            IEnumerable<int>? query = from i in arr.Select(i => i % 10).Where(i => i > 0).Distinct()
                                      select i;
            foreach (int i in query)
            {
                Console.WriteLine(i);
            }
        }
    }
} 