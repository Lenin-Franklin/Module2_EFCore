using System;
using System.Linq;
namespace HandsOnLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 12, 34, 45, 56, 64, 32, 21, 39, 50, 90, 67, 78, 89 };
            //fetch even values
            var result = from i in n where i % 2 == 0 select i;
            result = n.Where(i => i % 2 == 0).Select(i => i);
            //fetch odd values >30
            var result1 = from i in n where i % 2 != 0 && i > 30 select i;
            result1 = n.Where(i => i % 2 != 0 && i > 30);
            //fetch square or Array value
            var result2 = from i in n select i * i;
            result2 = n.Select(i => i * i);
            //fetch square of even values
            var result3 = from i in n
                          let k = i * i
                          where k % 2 == 0
                          select k;
            result3 = n.Where(i => i % 2 == 0).Select(i => i * i);
            var result4 = from i in n where i > 20 orderby i select i;
            //sort in descening order
            result4 = from i in n
                      where i%2!=0
                      orderby i descending select i;
            result = n.OrderBy(i => i);
            result = n.Where(i => i % 2 == 0).OrderByDescending(i => i);
            foreach(var item in result4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(result4.Max()); //return Max value.

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
