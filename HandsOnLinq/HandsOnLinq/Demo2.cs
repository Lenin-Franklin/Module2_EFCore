using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace HandsOnLinq
{
    class Demo2
    {
        static void Main()
        {
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var query = numbers.ElementAt(4);
            //Console.WriteLine(query);
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var query = numbers.ElementAtOrDefault(9);
            //Console.WriteLine(query);
            //deffered execution
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var result = from i in numbers where i % 2 == 0 select i;
            numbers[0] = 10;
            //foreach (var item in result)
            //    Console.WriteLine(item);
            //immdiate excuation
            var result1 = numbers.Where(i => i % 2 == 0).ToArray();
            numbers[0] = 1;
            foreach (var item in result1)
                Console.WriteLine(item);

        }
    }
}
