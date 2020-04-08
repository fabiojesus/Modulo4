using System;
using System.Linq;
using Common;

namespace Worksheet14
{
    public class GroupOne
    {
        public static void Ex01()
        {
            var list = string.Empty;
            var fst = InputRequest.RequestInteger("Número");
            FirstNaturalNumbers(fst, ref list);
            Console.WriteLine(list);
        }

        private static int FirstNaturalNumbers(int n, ref string list)
        {
            if (n == 1)
            {
                list = n +" "+ list;
                return 1;
            }
            list = n + " " + list;
            return FirstNaturalNumbers(n-1, ref list);
        }

        public static void Ex02()
        {
            var list = string.Empty;
            var fst = InputRequest.RequestInteger("Número");
            FirstNaturalNumbers(fst, ref list);
            Console.WriteLine(list.Reverse());
        }
        public static void Ex03()
        {
            var fst = InputRequest.RequestInteger("Número");
            Console.WriteLine(SomarNaturalNumbers(fst));
        }

        private static int SomarNaturalNumbers(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n + SomarNaturalNumbers(n - 1);
        }

        public static void Ex04()
        {
            var fst = InputRequest.RequestInteger("Primeiro número");
            var snd = InputRequest.RequestInteger("Segundo número");
            for (var i = (fst = (fst < snd ? fst : snd)); i < (fst = (fst < snd ? snd : fst)); i++)
            {
                if (i % 2 == 0) Console.Write(i+" ");
            }
        }


        public static void Ex05()
        {
            var list = string.Empty;
            var num = InputRequest.RequestInteger("Introduza um número");
            Fib(num, ref list);
            Console.WriteLine(list);
        }

        private static int Fib(int n, ref string list)
        {
            if (n <= 1)
            {
                list += n + " ";
                return n;
            }
            string u = "";
            var fib = Fib(n - 1, ref list) + Fib(n - 2, ref u);
            list += fib + " ";
            return fib;
        }


        public static void Ex06()
        {
            var num = InputRequest.RequestInteger("Introduza um número");
            Console.WriteLine($"{num}! = {factorial(num)}");
        }

        private static int factorial(int n)
        {
            if (n == 1) return 1;
            return n * factorial(n - 1);
        }
    }
}
