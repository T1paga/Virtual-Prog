using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ex1 = new int[3] { 5, 3, 4 };
            Console.WriteLine(HW1.QueueTime(ex1, 1));
            int[] ex2 = new int[4] { 10, 2, 3, 3 };
            Console.WriteLine(HW1.QueueTime(ex2, 2));
            int[] ex3 = new int[3] { 2, 3, 10 };
            Console.WriteLine(HW1.QueueTime(ex3, 2));
        }
    }

    public class HW1
    {
        public static long QueueTime(int[] customers, int n)
        {
            var checkout = new int[n];

            foreach (var counter in customers)
            {
                checkout[Array.IndexOf(checkout, checkout.Min())] += counter;
            }

            return checkout.Max();
        }
    }


}
