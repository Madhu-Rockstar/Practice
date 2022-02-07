using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class ExceptionHandlings
    {
        static void Main()
        {
            mahesh:
            Console.WriteLine("Enter a Beautiful Number:");
            int n = 0;
            try
            {
                n = int.Parse(Console.ReadLine());
               
            }
            catch(FormatException)
            {
                Console.WriteLine("Enter only number not string values:");
                goto mahesh;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("you are dividing with zero plse enter one more number not zero ");
                goto mahesh;
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Enter the values between {int.MinValue} and {int.MinValue}");
                goto mahesh;
            }
            finally
            {
                Console.WriteLine("Thank You for your co-operation");
            }
            Console.WriteLine("You Beautiful number is: "+n);
        }
    }
}
