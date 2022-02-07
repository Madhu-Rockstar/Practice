using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Patient
    {
        public int patientid { get; set; }
        public string patientname { get; set; }
        public DateTime dateofbitrh { get; set; }
        public DateTime dateofvisit { get; set; } = DateTime.Now;
        public string doctorname { get; set; }
        public double billpayment { get; set; }
    }
    class testing
    {
        static Patient createpatient()
        {
            Patient p = new Patient();
            p.patientid = Input.getint("Enter the patientid:");
            p.patientname = Input.getstring("Enter the patientname:");
            //p.dateofbitrh = Input.getdate("Enter the dateofbirth:");
            p.doctorname = Input.getstring("Enter the doctorname:");
            p.billpayment = Input.getdouble("Enter the bill for the doctor:");
            return p;
        }
        static void Main()
        {
            Patient per = createpatient();
            Console.WriteLine($"The details of {per.patientname} is stored:");
        }
    }
}
