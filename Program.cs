using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Value_of_any_character
{
    class Program
    {
       

        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Enter any  character:\n");
            s = Console.ReadLine();
            foreach (var c in s)
            {
                Console.Write((int)c);
                Console.Write("\n");
            }
        }
    }
}
