using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDisposableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            User obj = new User("Naveen", "Suma");
            obj.Dispose();
            Console.ReadLine();
        }
    }
}
