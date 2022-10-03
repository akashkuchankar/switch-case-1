using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your language");
            Console.WriteLine("1.marathi");
            Console.WriteLine("2.hindhi");
            Console.WriteLine("3.english");
            int A = Convert.ToInt32(Console.ReadLine());
            switch(A)
            {
                case 1: Console.WriteLine("you have selected marathi");
                    break;
                    case 2: Console.WriteLine("you have selected hindhi");
                    break ;
                    case 3: Console.WriteLine("you have selected english");
                    break;
                    default: Console.WriteLine("wrong number choose");
                    break;

            }
        }
    }
}
