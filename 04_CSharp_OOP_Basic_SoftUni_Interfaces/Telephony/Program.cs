using System;
using System.Collections.Generic;

namespace Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone();   
            string[] phones = Console.ReadLine().Split();
            foreach (var phone in phones)
            {
                Console.WriteLine(smartphone.Call(phone));
                
            }
            string[] urls = Console.ReadLine().Split();
            foreach (var url in urls)
            {
                Console.WriteLine(smartphone.Browse(url));
            }

        }
    }
}