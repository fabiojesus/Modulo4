using System;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using Worksheet13;

namespace ConsoleApp
{
    public class A { }
    public class B : A { }
    public class C : A { }

    class Program
    {



        static void Main(string[] args)
        {
            JogoDaForca.Start();
        }

        static int Factorial(int num)
        {
            if (num == 1) return num;
            return num * (Factorial(num - 1));
        }

    }
}
