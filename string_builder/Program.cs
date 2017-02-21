using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_builder
{
    class Program
    {
        static void Main(string[] args)
        {
          
            StringBuilder s = new StringBuilder("Hi");
            string newstr = "Ilyas";
            s.Append(newstr);
            Console.WriteLine(s);
            Console.ReadLine();

        }
    }
}
