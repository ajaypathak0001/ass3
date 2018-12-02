using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3AjaypathakP2
{
    class Program
    {
        static void Main(string[] args)
        {
            int firs;
            int scn;
            string op;
            int result;
            try
            {
            again:
                Console.Write("Enter 1 number");
                firs = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter 2 number : ");
                scn = Convert.ToInt32(Console.ReadLine());
            num:
                Console.Write("Enter operation");
                op= Console.ReadLine();
                if (op == "multiplication")
                {
                    result = firs * scn;
                    Console.WriteLine(firs + "x" + scn + "=" + result);
                    goto again;
                }
                else if (op == "division")
                {
                    result = firs / scn;
                    Console.WriteLine(firs + "/" + scn + "=" + result);
                    goto again;
                }
                else if (op == "addition")
                {
                    result = firs + scn;
                    Console.WriteLine(firs + "+" + scn + "=" + result);
                    goto again;
                }
                if (op == "subraction")
                {
                    result = firs - scn;
                    Console.WriteLine(firs + "-" + scn + "=" + result);
                    goto again;
                }
                else
                {
                    Console.WriteLine("Enter valid operation");
                    goto num;
                }

            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Enter arithmetic expression");
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter a valid number");
            }
        }
    }
}
