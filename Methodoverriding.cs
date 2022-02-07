using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Parent
    {
        public void simple() => Console.WriteLine("It is a simple class:");
        public virtual void Makepayment(string mode,double amount)
        {
            if(mode=="cash" || mode == "check")
            {
                Console.WriteLine($"You are selected {mode} and amount is {amount} ");
            }
            else
            {
                Console.WriteLine($"Sorry....mode is incorrect");
            }
        }
    }
    class Child:Parent
    {
        public override void Makepayment(string mode,double amount)
        {
            if (mode=="cash" || mode=="card" || mode == "check")
            {
                Console.WriteLine($"You selected mode is {mode} and amount is {amount}");
            }
            else
            {
                Console.WriteLine("This mode is not accepted:");
            }
        }
    }
    class Methodoverriding
    {
        static void Main()
        {
            Child c = new Child();
            c.Makepayment("check",20000);
        }
    }
}
