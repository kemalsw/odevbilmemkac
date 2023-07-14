using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if (time>18 && time<22)
            {
                Console.WriteLine("iyi akşamlar");
            }
            else if (time<18 && time>12)
            {
                Console.WriteLine("İyi günler");
            }
            else if (time<12 && time>5)
            {
                Console.WriteLine("Günaydın");
            }
            else
            {
                Console.WriteLine("İyi geceler");
            }
            Console.ReadLine();
        }
            
    }
}
