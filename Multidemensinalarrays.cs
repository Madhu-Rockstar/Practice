using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Multidemensinalarrays
    {
        static void Main()
        {
            int[,] arr = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] arr2 = { { 10, 20, 30 }, { 40, 50, 60 }, { 70, 80, 90 } };
            int[,] arr3 = new int[3,4];
            arr3[0, 1] = 10;
            arr3[1, 1] = 20;
            arr3[2, 1] = 30;
            arr3[3, 1] = 40;
            for (int i = 0; i <=arr.Length; i++)
            {
                for( int j = 0; j <=arr.Length; j++)
                {
                    Console.WriteLine(arr[i,j]+" ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
