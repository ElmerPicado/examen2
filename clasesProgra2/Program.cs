using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesProgra2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            entrada();
            Clicofor();
            
        }
        static void entrada()
        {
            string nombre = "";
            Console.WriteLine("HOLA");
            Console.WriteLine("CUAL ES TU NOMRBE");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola :" + nombre);
           

        }

        static void Clicofor()
        {
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);













            }
        }
        
       
    }
}
