using Common;
using System;
using static Common.InputRequest;

namespace Ficha12
{
    public class F12G1
    {
        public static void Ex1()
        {
            var total = 1.0;
            var output = string.Empty;
            for (var counter = 0; counter < 3; counter++)
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

        public static void Ex3()
        {
            var x = RequestDouble("Introduza o 1º número");
            var y = RequestDouble("Introduza o 2º número");
            var z = RequestDouble("Introduza o 3º número");
            Console.WriteLine($"{z}({x}+{y}) = {(x+y)*z}");
            Console.WriteLine($"({x}x{y})+({y}x{z}) = {(x*y)+(y*z)}");
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

        public static void Ex5()
        {
            var res = InputRequest.RequestString("Hello?");
            if (res == "Is it me you're looking for?")
                Console.WriteLine("I can see it in your eyes");
        }

        public static void Ex06()
        {
            var contagem = InputRequest.RequestInteger("Quantos itens?");
            while (contagem > 0)
            {
                if (contagem % 2 == 0) Console.WriteLine("Um pra ti");
                else Console.WriteLine("Um pra mim");
                contagem--;
            }
        }
        public static void Ex07()
        {
            var ano = RequestInteger("Insira um ano");
            bool isLeap = false;
            if (ano % 4 == 0)
            {
                if (ano % 100 != 0 || ano % 400 == 0) isLeap = true;
            }
            Console.WriteLine(isLeap ? "É bissexto" : "Não é bissexto");
        }
        public static void Ex08()
        {
            var beerCount = 99;
            while (beerCount > 0)
            {
                Console.WriteLine($"{beerCount} bottles of beer on the wall, 99 bottles of beer.");
                beerCount--;
                if (beerCount != 0)
                    Console.WriteLine($"Take one down, pass it around, {beerCount} bottles of beer on the wall...");
                else
                    Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer.");
                Console.WriteLine("");
            }
        }

        public static void Ex09()
        {
            var ladoA = RequestDouble("Introduza o 1º lado");
            var ladoB = RequestDouble("Introduza o 2º lado");
            var ladoC = RequestDouble("Introduza o 3º lado");
            if(ladoA == ladoB && ladoA == ladoC) Console.WriteLine("Equilátero");
            else if(ladoA != ladoB && ladoA != ladoC) Console.WriteLine("Escaleno");
            else Console.WriteLine("Isósceles");
        }

        public static void Ex10()
        {
            var valorInicial = InputRequest.RequestDouble("Qual o valor inicial?");
            var valorFinal = InputRequest.RequestDouble("Qual o valor final?");
            var balanco = valorFinal - valorInicial;
            if (balanco < 0) Console.WriteLine("Prejuizo");
            else if (balanco == 0) Console.WriteLine("Neutro");
            else Console.WriteLine("Lucro");
        }

        public static void Ex11()
        {
            var mes = InputRequest.RequestInteger("Qual o mês?");
            if (mes < 1 && mes > 12)
            {
                Console.WriteLine("Mês inválido");
                return;
            }

            var dias = (mes == 2) ? "28 ou 29" : 
                ((mes % 2 == 0 && mes < 8) || mes > 7 && mes % 2 == 1) ? "30" : "31";
            var extenso = string.Empty;
            switch (mes)
            {
                case 1: extenso = "Janeiro"; break;
                case 2: extenso = "Fevereiro"; break;
                case 3: extenso = "Março"; break;
                case 4: extenso = "Abril"; break;
                case 5: extenso = "Maio"; break;
                case 6: extenso = "Junho"; break;
                case 7: extenso = "Julho"; break;
                case 8: extenso = "Agosto"; break;
                case 9: extenso = "Setembro"; break;
                case 10: extenso = "Outubro"; break;
                case 11: extenso = "Novembro"; break;
                case 12: extenso = "Dezembro"; break;
            }
            Console.WriteLine($"{extenso} - {dias} dias");
        }

       public static void Ex12()
        {
            var num = InputRequest.RequestInteger("Qual a dimensão do triângulo?");
            var stars = num*2-1;
            var dimCounter = 0;
            while (dimCounter < num)
            {
                var spaces = 0;
                while (spaces != dimCounter)
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
                stars -= 2;
                Console.WriteLine("");
                dimCounter++;
            }
        }

       public static void Ex13()
       {
           var consumo = InputRequest.RequestDouble("Quantos litros consumidos?");
           var regiao = InputRequest.RequestKey("Qual a região?");
           var total = 0.0;
           switch (regiao)
           {
                case ConsoleKey.A: total = consumo * 2; break;
                case ConsoleKey.B: total = consumo * 1.2; break;
                case ConsoleKey.C: total = consumo * 1; break;
                case ConsoleKey.D: total = consumo * 0.75; break;
           }
           Console.WriteLine($"O valor a pagar é {total}");

       }

        public static void Ex14()
        {
            var counter = InputRequest.RequestDouble("Quantos números a apresentar?");
            for (var i = 1; i <= counter; i++)
            {
                Console.Write(Fibonacci(i)+" ");
            }
        }

        private static int Fibonacci(int count)
        {
            if (count <= 1)
            {
                return 1;
            }
            var current = 1;
            var previous = 1;
            for (var i = 2; i < count; ++i)
            {
                int temp = current;
                current += previous;
                previous = temp;
            }
            return current;
        }

        public static void Ex15()
        {
            var numero = InputRequest.RequestInteger("Qual o número?");
            var currFib = 0;
            var fibCounter = 0;
            while (currFib < numero)
            {
                currFib = Fibonacci(fibCounter);
                fibCounter++;
                if(numero == currFib) Console.WriteLine($"{numero} é Fibonice!");
                else if(numero<currFib) Console.WriteLine($"{numero} não é Fibonice!");
            }

        }

        public static void Ex16()
        {
            var min = 1;
            var max = 100;
            var numeroCerto = false;
            while (!numeroCerto)
            {
                Console.WriteLine();
                var avg = (int)Math.Floor((double)(min + max) / 2);
                var intConf = max - min;
                var keyOk = false;
                if(intConf < 2)
                {
                    for(var i = min; i < max+1; i++)
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

                if (numeroCerto) continue;
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
