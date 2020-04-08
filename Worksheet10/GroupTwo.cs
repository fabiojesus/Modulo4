using System;
using System.Collections.Generic;
using System.Text;
using Common;

namespace Worksheet10
{
    public class GroupTwo
    {
        /// <summary>
        /// Solicita um factóide e apresenta-o como conhecimento existente
        /// </summary>
        public static void Ex01()
        {
            var factoid = InputRequest.RequestString("Diz-me algo que eu não saiba");
            Console.WriteLine("Eu já sabia que " + factoid);
        }

        /// <summary>
        /// Solicita dois numeros, apresentando-os sequencialmente
        /// </summary>
        public static void Ex02()
        {
            var fstNum = InputRequest.RequestDouble("Introduz dois números");
            double.TryParse(Console.ReadLine(), out double sndNum);
            Console.WriteLine($"O primeiro número é {fstNum} e o segundo número é {sndNum}");
        }

        /// <summary>
        /// Converte uma temperatura em ºC para ºF e K
        /// </summary>
        public static void Ex03()
        {
            var temp = InputRequest.RequestDouble("Introduz a temperatura");
            var tempF = temp * 9 / 5 + 32;
            var tempK = temp + 273.15;
            Console.WriteLine($"A temperatura {temp}ºC é {tempF}ºF e {tempK}K");
        }
    }
}
