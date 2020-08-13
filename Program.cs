using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_project
{
    class Program
    {
        /// <summary>
        /// method to calculate fibonnci series
        /// </summary>
        /// <param name="arr"> stores the size of the arr</param>
        static void fib(int[] arr)
        {
            
            arr[0] = 1; arr[1] = 1;
            int sum = 2;
            for (int i = 2; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
                sum += arr[i];
            }
            Console.WriteLine("sum: " + sum);
        }
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            fib(arr);
            Console.ReadLine();
        }
    }
}
