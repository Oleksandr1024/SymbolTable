using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymbolTable
{
    class Program
    {
        static void Main(string[] args)
        {
                       
                 

            Console.WriteLine("Введите нижнюю границу диапазона");
            string n1 = Console.ReadLine();
            Console.WriteLine("Введите верхнюю границу диапазона");
            string n2 = Console.ReadLine();

            int i = int.Parse(n1);
            int s = int.Parse(n2);
            
            
            for (; i < s; i++)
            {
                
                    Console.Write("["+i+"] -"+(char)(i) + " ");               
                
            }
            
                   
            Console.ReadKey();
        }
    }
}
