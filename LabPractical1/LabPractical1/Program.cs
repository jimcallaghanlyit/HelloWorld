using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPractical1
{
    class Program
    {
        static void Main(string[] args)
        {
            string mynumber = "";
            Console.WriteLine($"Please enter a number");
            mynumber = Console.ReadLine();
            Console.WriteLine($"The number you entered was {mynumber}");
            Console.ReadKey(); 
        }
    }
}
