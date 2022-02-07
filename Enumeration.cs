using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    enum week {sunday,monday,tuesday,wednesday,thrsday,friday,saturday };
    class Enumeration
    {
        static void Main()
        {
            foreach(int i in Enum.GetValues(typeof(week)))
            {
                Console.WriteLine(i);
            }
            foreach(string i in Enum.GetNames(typeof(week)))
            {
                Console.WriteLine(i);
            }
        }
    }
}
