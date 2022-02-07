using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Arraysdeep
    {
        static void array6()
        {
            object[][] arr = new object[4][];
            arr[0] = new object[] { "madhu",286,'m',99.9,true};
            arr[1] = new object[] { "nana",1000,'t',100.21,true};
            arr[2] = new object[] { "hemanth",3000,'h',32.0,false};
            arr[3] = new object[] { "lasya",300,'l',22,false};
            for(var i = 0; i < arr.Length; i++)
            {
                foreach(var j in arr[i])
                {
                    Console.Write(j+"    ");
                }
                Console.WriteLine();
            }
        }
        static void array5()
        {
            
                int[,] arr = new int[3, 3] { { 10, 0, 0 }, { 0, 20, 0 }, { 0, 0, 30 } };

                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.WriteLine();
                }
           
        }
        static void Main()
        {
            //array1();
            //array2();
            //array3();
            //array4();
            //array5();
            array6();
        }
        static void array4()
        {
            object[,] arr = new object[3, 3] { { "madhu", 0, 0 }, { 0, "nana", 0 }, { 0, 0, "hemanth" } };
            
            for(var i = 0; i < arr.GetLength(0); i++)
            {
                for(var j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
     
        }
        static void array3()
        {
            object[] arr = new object[] { 10, "Rocky",'c',20.3222};
            foreach(object i in arr)
            {
                Console.WriteLine(i);
            }
        }
        static void array2()
        {
            object[] arr = {10,"madhu",true,'m',20.23,10f };
            foreach(object i in arr)
            {
                Console.WriteLine(i);
            }
        }
        static void array1()
        {
            object[] arr = new object[10];
            arr[0] = 10;
            arr[1] = 15;
            arr[2] = 20;
            arr[4] = 40;
            arr[6] = 60;
            arr[8] = 100;
            foreach(object i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }    
}
