using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Zadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int i;
            int rez=0;
            Console.Write("Upisite broj do kojeg ce se zbrajati: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= n; i++)
            {
               rez +=i;
                
            }
            Console.Write("Zbroj prvih ");
            Console.Write(n);
            Console.Write(" brojeva je: ");
            Console.Write(rez);
            Console.ReadKey();
        
        }

    }
}
