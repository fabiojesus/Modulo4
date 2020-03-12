using System;
using Ficha10;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("************************\n************************\n**                    **\n**");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("     Módulo 4       ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("**\n**                    **");
                Console.Write("************************\n************************");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\n");
                var num = Common.InputRequest.RequestInteger("Seleccione a ficha:");
                if (num < 10 && num > 15) continue;
                switch (num)
                {
                    case 10: Ficha10.Menu.Run();break;
                    case 11: break;
                    case 12: break;
                    case 13: break;
                    case 14: break;
                    case 15: break;
                    default: continue;
                }
            }
            


        }
    }
}
