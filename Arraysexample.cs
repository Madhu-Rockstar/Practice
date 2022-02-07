using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Arraysexample
    {
        static void Main()
        {
            object[] arr = new object[] { 'M',20.34,10,20,true,30,40,"madhu"};
            int[] arr2 = new int[3];
            arr2[0] = 100;
            arr2[1] = 200;
            object[] arr3 = { 10, "madhu", 30, 'c',true, 50 };
            
            for (int i =0;i<arr2.Length;i++)
            {
                Console.WriteLine(arr2[i]);
                
            }
            Console.WriteLine();
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.WriteLine(arr3[i]);
                
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
