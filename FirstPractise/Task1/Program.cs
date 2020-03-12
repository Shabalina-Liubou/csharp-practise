using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            short variable = 15;
            object obj = variable;

            sbyte b_variable = (sbyte)(short)obj;

            Console.WriteLine("Type of b_variable is {0}, its value = {1}", b_variable.GetType().FullName, b_variable);

            Console.ReadLine();
        }
    }
}
