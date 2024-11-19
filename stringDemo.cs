using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class stringDemo
    {
        static void Main(string[] args)
        {
            //string str = "C# Programming";
            //Console.WriteLine("Str Length: " + str.Length);
            //string s1 = " with .NET Framework";
            //Console.WriteLine("Concat: " + string.Concat(str,s1)); //concat
            //Console.WriteLine(str.ToUpper()); // uppwercase 
            //Console.WriteLine(str.ToLower()); // lowercase
            //Console.WriteLine(string.Equals(str,s1)); // compare two strings
            //// String Interpolation = $ sign
            //string name = "Prafull";

            //string msg = $"Welcome {name}";
            //Console.WriteLine(msg);

            // date formatting
            DateTime now = DateTime.Now;
            //Console.WriteLine(now);
            string dtStr = String.Format("{0:d} at {0:t}", now);

            Console.WriteLine(dtStr);
        }
    }
}
