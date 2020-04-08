using System;
using Common;

namespace Worksheet11
{
    public class GroupThree
    {
        public static void Ex01()
        {
            var num = InputRequest.RequestInteger("Introduza um número");
            if (num % 2 == 0) Console.WriteLine(num * 3);
            else Console.WriteLine(num * 2);
        }

        public static void Ex02()
        {
            var num = InputRequest.RequestInteger("Qual a dimensão do triângulo?");
            var stars = 1;
            while (num > 0)
            {
                num--;
                var spaces = 0;
                while (spaces != num)
                {
                    Console.Write(" ");
                    spaces++;
                }

                var starCounter = 0;
                while (stars != starCounter)
                {
                    Console.Write("*");
                    starCounter++;
                }
                stars+= 2;
                Console.WriteLine("");
            }
        }


    }
}
