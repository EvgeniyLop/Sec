using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Говнокод //секундомер действия кода
{
    class Program
    {
        public static bool cod = true;
        public static int sec = 0;
        static void Main(string[] args)
        {
            Method();
            Console.WriteLine("Программа начала работу");
            for (int i = 0; i <=100000; i++)
            {
                Console.WriteLine(i);
                
            }
            cod = false; 
            Console.WriteLine("Программа работала {0}",sec);
        }
        async static void Method()
        {
            await Task.Run(() =>
            {
                while (cod == true)
                {
                    Thread.Sleep(1000);
                    sec++; 
                }
                return sec; 
            });
        }

    }
}
