using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practice
{
    class Files
    {
        static void Main()
        {
           FileStream shh=new FileStream(@"C:\Users\Madhusudhan M\source\repos\Practice\Practice\TextFile1.txt",FileMode.OpenOrCreate);

            //StreamWriter f = new StreamWriter(shh);
            //f.WriteLine(".......Madhu Rock star........ ");
            //f.WriteLine("..fuck offf ra reee...");
            //f.Write("mmmmmmmmmm");
            //f.WriteLine("anna yeee anna yee anna yee ann yee");
            //f.Close();


            //StreamReader f = new StreamReader(shh);
            //string line1 = s.ReadLine();
            //string line2 = s.ReadLine();
            //s.Close();

            //Console.WriteLine(line1);
            //Console.WriteLine(line2);

            //string line = "";
            //while ((line = f.ReadLine()) != null)
            //{
            //    Console.WriteLine(line);
            //}
            //f.Close();

            //shh.Close();
        }
    }
}
