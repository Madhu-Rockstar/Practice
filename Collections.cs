using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Collections
    {
        static void Main()
        {
            //List<object> shh = new List<object>();
            //shh.Add("madhu");
            //shh.Add("shiva");
            //shh.Add("santhosh");
            //shh.Add("rakshaj");
            //shh.Insert(1, "Dharani");
            //shh.Insert(3, "prasad");
            //shh.Remove("prasad");
            //shh.Add('c');
            //shh.Add(true);
            //shh.Add(10);
            //shh.Add(23.45);


            //HashSet<object> shh = new HashSet<object>();
            //shh.Add("madhu");
            //shh.Add("Rockstar");
            //shh.Add('c');
            //shh.Add(false);
            //shh.Add(109);
            //shh.Add(21.23);
            //shh.Remove("Rockstar");
            //shh.Remove('c');

            //Dictionary<object, object> shh = new Dictionary<object, object>();
            //shh.Add("name","madhu");
            //shh.Add("age",20);
            //shh.Add("number","7675933139");
            //shh.Add("flater", 'L');
            //shh.Remove("age");

            //Stack<object> shh = new Stack<object>();

            //shh.Push("madhu");
            //shh.Push(true);
            //shh.Push('l');
            //shh.Push(1000);
            //shh.Push(12.345);
            //shh.Pop();
            //shh.Reverse();

            //Queue<object> shh = new Queue<object>();

            //shh.Enqueue("madhu");
            //shh.Enqueue("Rockstar");
            //shh.Enqueue('c');
            //shh.Enqueue("madhu");
            //shh.Dequeue();

            //LinkedList<object> shh = new LinkedList<object>();

            //shh.AddFirst("madhu");
            //shh.AddFirst("Rockstar");
            //shh.AddLast("sudhan");

            SortedDictionary<int, string> shh = new SortedDictionary<int, string>();

            shh.Add(1, "madhu");
            shh.Add(4, "Rocky");
            shh.Add(10, "surya");
            shh.Add(6,"Ramcharan");
            shh.Remove(6);
            foreach (var i in shh)
            {
                Console.WriteLine(i);
            }
        }   
    }
}
