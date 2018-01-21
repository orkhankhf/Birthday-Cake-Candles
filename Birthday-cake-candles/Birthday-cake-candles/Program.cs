using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Birthday_cake_candles
{
    class Program
    {
        int n;
        static int birthdayCakeCandles(int n, int[] ar)
        {
            n = ar.Max();
            int count = 0;
            for(int i=0; i<ar.Length; i++)
            {
                if (n == ar[i])
                {
                    count++;
                }
            }
            return count;
            //ANOTHER SOLUTION
            //List<int> list = ar.ToList();
            //var x = from num in ar where num == ar.Max() select num;
            //return x.Count();
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = birthdayCakeCandles(n, ar);
            Console.WriteLine(result);
        }
    }
}
