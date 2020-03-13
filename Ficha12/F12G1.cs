using Common;
using System;
using static Common.InputRequest;

namespace Ficha12
{
    public class F12G1
    {
        public static void Ex1()
        {
            double total = 1.0;
            string output = string.Empty;
            for (int counter = 0; counter < 3; counter++)
            {
                var currentNumber = RequestDouble("Introduza um número");
                total *= currentNumber;
                output += $"{currentNumber}";
                if (counter < 2)
                    output += $" x";
                output += " ";
            }
            Console.WriteLine($"{output}= {total}");
        }

        public static void Ex2()
        {
            var firstNumber = RequestDouble("Introduza o 1º número");
            var secondNumber = RequestDouble("Introduza o 2º número");
            Console.WriteLine($"{firstNumber} + {secondNumber} = {(firstNumber + secondNumber)}");
            Console.WriteLine($"{firstNumber} - {secondNumber} = {(firstNumber - secondNumber)}");
            Console.WriteLine($"{firstNumber} * {secondNumber} = {(firstNumber * secondNumber)}");
            Console.WriteLine($"{firstNumber} / {secondNumber} = {(firstNumber / secondNumber)}");
            Console.WriteLine($"{firstNumber} % {secondNumber} = {(firstNumber % secondNumber)}");
        }

        public static void Ex4()
        {
            Console.WriteLine("Introduza um número");
            var num = int.Parse(Console.ReadLine());
            for(var i = 2; i <= num; i++)
            {
                var isPrime = true;
                for(var j = 2; j <i; j++)
                {
                    if(i%j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) Console.WriteLine(i+" ");
            }
        }

        public static void Ex16()
        {
            int min = 1;
            int max = 100;
            bool numeroCerto = false;
            while (!numeroCerto)
            {
                Console.WriteLine();
                var avg = (int)Math.Floor((double)(min + max) / 2);
                var intConf = max - min;
                var keyOk = false;
                if(intConf < 2)
                {
                    for(int i = min; i < max+1; i++)
                    {
                        Console.WriteLine($"É {i}?");
                        var key = Console.ReadKey().Key;
                        if (key == ConsoleKey.Y || key == ConsoleKey.S)
                        {
                            numeroCerto = true;
                            break;
                        }
                        Console.WriteLine("");

                    }
                }
                if (!numeroCerto)
                {
                    while (!keyOk)
                    {
                        Console.WriteLine($"O número é inferior a {avg}?");
                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.Y:
                            case ConsoleKey.S:
                                keyOk = true;
                                max = avg - 1;
                                break;
                            case ConsoleKey.N:
                                keyOk = true;
                                min = avg;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }

    }
}
