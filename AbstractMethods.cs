using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    abstract class Account
    {
        public int num { get; set; }
        public string name { get; set; }
        public double balance { get; set; }
        public void credit(double money)
        {
            balance = balance + money;
        }
        public void debit(double money)
        {
            if(money > balance)
            {
                throw new Exception("Insufficent funds");   
            }
            balance = balance - money;
        }
        public abstract void details();
        
    }
    class simple:Account
    {
        public override void details()
        {
            double p = balance;
            double t = 12;
            double r = 2;
            double res = balance+(p * t * r / 100);
            Console.WriteLine($"The Balance is {res}");
        }
    }
    class AbstractMethods
    {
        static void Main()
        {
            simple s = new simple();
            s.num = 1234;
            s.name = "madhu";
            s.balance = 100000;
            s.credit(500);
            s.debit(10);
            s.details();
        }
    }
}
