using System;
using Common;

namespace Ficha11
{
    public class F11G2
    {
        public static void Ex01()
        {
            var temp = InputRequest.RequestDouble("Qual a temperatura?");
            var scale = "";
            do
            {
                scale = InputRequest.RequestString("Qual a escala? (C, K, F)");
            } while (scale != "C" && scale != "F" && scale != "K");

            switch (scale)
            {
                case "C":
                    Console.WriteLine($"{temp}ºC é equivalente a {(temp + 273.15)}K e {(temp * 9 / 5 + 32)}ºF");
                    break;
                case "K": 
                    Console.WriteLine($"{temp}K é equivalente a {(temp - 273.15)}ºC e {(temp * 9 / 5 - 459.67)}ºF");
                    break;
                case "F":
                    Console.WriteLine($"{temp}ºF é equivalente a {(temp - 32) * 5 / 9 }ºC e {((temp + 459.67) * 5 / 9 )}K");
                    break;
            }
        }

        public static void Ex02()
        {
            var limit = InputRequest.RequestInteger("Qual o limite?");
            for (var counter = 0; counter < limit; counter++)
            {
                if (counter % 2 == 1) Console.WriteLine(counter);
            }
        }

        public static void Ex03()
        {
            var chars = "";
            var input = "";
            do
            {
                input = InputRequest.RequestString("Introduz um número, caracteres, ou enter para terminar");
                chars = input + chars;
            } while (input != "");
            Console.WriteLine(chars);
        }
    }
}
