using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _11.IF_STATEMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ismale = true;
            if (ismale) 
            {
                Console.WriteLine("you are male");
            }
            else
            {
                Console.WriteLine("you are female");
            }
            bool istall = false;
            if (istall && ismale)
            {
                Console.WriteLine("you are both male and tall.");
            }
            else if (istall && ismale)
            {
                Console.WriteLine("you are not tall but you are male");

            }
            else {
                Console.WriteLine("you are either not tall or not a male.");
            }

            Console.Read();

        }
    }
}
