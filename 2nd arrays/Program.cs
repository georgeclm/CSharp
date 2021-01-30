using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Study in array sort, reverse, clone and  copy*/
            int[][][] jaggedArray = new int[][][]
            {
                new int[][] { new int[] { 1, 2 }, new int[] { 3, 4, 5 } },
                new int[][] { new int[] { 6 } },
                new int[][] { new int[] {7,8,9}, new int[] { 10, 11, 12 }, new int[] {13, 14, 15 } }
            };
            Console.WriteLine(jaggedArray[2][1][1]);
            int[,,,] theArray = new int[2, 3, 3, 3]
            {
                {
                    {
                        { 1, 2, 3 },
                        { 4, 5, 6 },
                        { 7, 8, 9 }
                    },
                    {
                        { 1, 2, 3 },
                        { 4, 5, 6 },
                        { 7, 8, 9 }
                    },
                    {
                        { 1, 2, 3 },
                        { 4, 5, 6 },
                        { 7, 8, 9 }
                    }
                },
                {
                    {
                        { 1, 2, 3 },
                        { 4, 5, 6 },
                        { 7, 8, 9 }
                    },
                    {
                        { 1, 2, 3 },
                        { 4, 5, 6 },
                        { 7, 8, 9 }
                    },
                    {
                        { 1, 2, 3 },
                        { 4, 5, 6 },
                        { 7, 8, 9 }
                    }
                }
            };
            Console.WriteLine(theArray[0, 0, 2, 0]);
            int limit = 0;
            int seclimit = 0;
            int j = 0;
            int i = 0;
            Console.Write("Enter how many rows: ");
            limit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter how many columns: ");
            seclimit = Convert.ToInt32(Console.ReadLine());
            double[,] array = new double[limit, seclimit];
            Console.WriteLine("Enter your number ");
            for (i = 0; i < limit; i++)
            {
                for (j = 0; j < seclimit; j++)
                {
                    array[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            int[,] numberGrid = {
            {1, 2 },
            {3, 4 },
            {5, 6 }
            };
            foreach (int k in array)
            {
                Console.WriteLine("Your input number in array is: {0}", k);
            }

            Console.WriteLine(numberGrid[2, 1]);
            Console.Write(Dayname[1]);
            Console.ReadLine();
        }
        static readonly string[] Dayname = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

    }
}
