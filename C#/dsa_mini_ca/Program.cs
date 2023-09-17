using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_CA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 1, 2 ,4 , 9, 7, 6,4};
            int target = 16;
            Console.Write("Result is ");
            printArray(twosum(input, target));
        }
        public static int[] twosum(int[] arr, int target)
        {
            Dictionary<int, int> A = new Dictionary<int,int>();
            for (int i = 0; i < arr.Length; i++)
            {
                int diff = target - arr[i];
                if (A.ContainsKey(diff))
                {
                    return new int[] { arr[i], diff };
                }
                A.Add(arr[i], diff);

            }
            return new int[] {-1,-1};
        }

        public static void printArray(int[] arr)
        {
            for (int i=0; i< arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    Console.Write(arr[i]);
                }
                else
                {
                    Console.Write(arr[i] + ", ");
                }
            }
            Console.Write("\n");
        }

    }
}

