using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    enum Gender { mr,ms}
    class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public double salary { get; set; }
        public string address { get; set; }
        public Gender gender { get; set; }
    }
    class Classesandobject
    {
        static void Main()
        {
            Employee emp = new Employee { id=1,name="madhu",salary=60000,address="banglore",gender=Gender.mr};
            Console.WriteLine($"The name is {emp.name} id {emp.id} address is {emp.address} and salary is {emp.salary} ");

        }
    }
}
