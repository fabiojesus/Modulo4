using System;
using Common;

namespace Worksheet11
{
    public class GroupOne
    {
        public static void Ex01()
        {
            var grade = InputRequest.RequestDouble("Qual a nota");
            if (grade > 9.44)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Passou");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Chumbou");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Ex02()
        {
            var weight = InputRequest.RequestDouble("Qual o peso?");
            var height = InputRequest.RequestDouble("Qual a altura?");
            var bmi = weight / (height * height);
            Console.Write("De acordo com o seu BMI, você está ");
            if(bmi < 18.5) Console.WriteLine("abaixo do peso");
            else if(bmi >= 18.5 && bmi < 25) Console.WriteLine("normal");
            else if(bmi > 25 && bmi < 29.99) Console.WriteLine("acima do peso");
            else Console.WriteLine("obeso");
        }


        public static void Ex03()
        {
            var number = InputRequest.RequestInteger("Qual o número?");
            if(number % 3 == 0 && number % 7 == 0) Console.WriteLine("O número é divisivel por 3 e 7");
            else if(number % 3 == 0) Console.WriteLine("O número é divisivel por 3");
            else if(number % 7 == 0) Console.WriteLine("O número é divisivel por 7");
            else Console.WriteLine("O número não é divisivel por 3 nem por 7");
        }

        public static void Ex04()
        {
            var number = InputRequest.RequestInteger("Qual o número?");
            if(number >= 30 && number <= 50) Console.WriteLine($"{number} está entre 30 e 50, inclusive");
            else Console.WriteLine($"{number} não está entre 30 e 50, inclusive");
        }

        public static void Ex05()
        {
            var number = InputRequest.RequestInteger("Qual o número?");
            if (number >= 10 && number <= 20) Console.WriteLine($"{number} está entre 10 e 20, inclusive");
            else Console.WriteLine($"{number} não está entre 10 e 20, inclusive");
        }


        public static void Ex06()
        {
            var number = InputRequest.RequestInteger("Qual o piso?");
            if (number < -2 || number > 6) Console.WriteLine("O piso não existe");
            if (number == 3 || number == 5) Console.WriteLine("Piso indisponivel");
            else Console.WriteLine($"Piso {number}");
        }

        public static void Ex07DoWhile()
        {
            var soma = 0.0;
            var output = string.Empty;
            var count = 0;
            do
            {
                var num = InputRequest.RequestDouble($"Qual o {count+1} número");
                output += num;
                if (count < 9) output += " + ";
                soma += num;
                count++;
            } while (count < 10);
            Console.WriteLine($"{output} = {soma}");
        }

        public static void Ex07While()
        {
            var soma = 0.0;
            var output = string.Empty;
            var count = 0;
            while (count < 10)
            {
                var num = InputRequest.RequestDouble($"Qual o {count + 1} número");
                output += num;
                if (count < 9) output += " + ";
                soma += num;
                count++;
            }
            Console.WriteLine($"{output} = {soma}");
        }

        public static void Ex07For()
        {
            var soma = 0.0;
            var output = string.Empty;
            for (var count = 0; count < 10; count++)
            {
                var num = InputRequest.RequestDouble($"Qual o {count + 1} número");
                output += num;
                if (count < 9) output += " + ";
                soma += num;
            }
            Console.WriteLine($"{output} = {soma}");
        }

        public static void Ex08()
        {
                var total = 0.0;
                var output = string.Empty;
                var counter = 1;
                ConsoleKey continuar;
                do
                {
                    RequestProduct(ref counter, ref total, ref output);
                    continuar = InputRequest.RequestKey("Continuar? (S/N)");
                } while (continuar != ConsoleKey.N);
                Console.WriteLine($"{output}\nTotal - {total}");
        }

        public static void Ex09()
        {
            var counter = 0;
            var soma = 0.0;
            double current;
            do
            {
                current = InputRequest.RequestDouble("Introduza um número diferente de 0, ou introduza 0 para terminar");
                if (current == 0.0) continue;
                soma += current;
                counter++;
            } while (current != 0.0);
            Console.WriteLine($"A média é {(soma/counter)}");
        }

        public static void Ex10()
        {
            var fstNumber = InputRequest.RequestDouble("Introduza um número");
            var sndNumber = InputRequest.RequestDouble("Introduza um número");
            var opt = InputRequest.RequestCharacter("Introduza uma operação");
            switch (opt)
            {
                case '+': Console.WriteLine($"{fstNumber} + {sndNumber} = {(fstNumber + sndNumber)}");break;
                case '-': Console.WriteLine($"{fstNumber} - {sndNumber} = {(fstNumber - sndNumber)}");break;
                case '*': Console.WriteLine($"{fstNumber} x {sndNumber} = {(fstNumber * sndNumber)}");break;
                case '/': Console.WriteLine($"{fstNumber} / {sndNumber} = {(fstNumber / sndNumber)}");break;
                case '%': Console.WriteLine($"{fstNumber} % {sndNumber} = {(fstNumber % sndNumber)}");break;
            }

        }

        public static void Ex11()
        {
            var @char = InputRequest.RequestCharacter("Introduza um caracter");
            PrintGrid(3, 3, @char);
        }

        public static void Ex12()
        {
            var num = InputRequest.RequestInteger("Introduza o número");
            var @char = InputRequest.RequestCharacter("Introduza um caracter");
            PrintGrid(num, num, @char);
        }

        public static void Ex13()
        {
            var rows = InputRequest.RequestInteger("Introduza o número de linhas");
            var cols = InputRequest.RequestInteger("Introduza o número de colunas");
            var @char = InputRequest.RequestCharacter("Introduza um caracter");
            PrintGrid(rows, cols, @char);
        }

        private static void PrintGrid(int rows, int cols, char @char)
        {
            for (var rowCount = 0; rowCount < rows; rowCount++)
            {
                for (var colCount = 0; colCount < cols; colCount++)
                {
                    Console.Write($"{@char} ");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Concats a number to the output with a prefix, and adds the inputted value to a totalizer
        /// </summary>
        /// <param name="counter">just a number to notify the product's position'</param>
        /// <param name="total">the current total</param>
        /// <param name="output">the current output</param>
        private static void RequestProduct(ref int counter, ref double total, ref string output)
        {
            var name = InputRequest.RequestString($"Introduza o nome do {counter}º produto");
            var price = InputRequest.RequestDouble($"Introduza o preço do {counter}º produto");
            var quant = InputRequest.RequestDouble($"Introduza a quantidade do {counter}º produto");
            var totPrice = quant * price;
            total += totPrice;
            output += $"{name} ({quant}) - {totPrice}\n";
            counter++;
        }
    }
}
