using System;
using Common;
namespace Ficha10
{
    public class F10G1
    {
        /// <summary>
        /// Solicitar um nome e apresentar Olá [nome]
        /// </summary>
        public static void Ex1()
        {
            var name = InputRequest.RequestString("Introduza o nome");
            Console.WriteLine($"Olá {name}");
        }

        /// <summary>
        /// Solicitar dois números, a e b, e apresentar a soma
        /// </summary>
        public static void Ex2()
        {
            var firstNumber = InputRequest.RequestDouble("Introduza o 1º número");
            var secondNumber = InputRequest.RequestDouble("Introduza o 2º número");
            var total = firstNumber + secondNumber;
            Console.WriteLine($"{firstNumber} + {secondNumber} = {total}");
        }

        /// <summary>
        /// Solicitar dez números, e apresentar a soma
        /// </summary>
        public static void Ex3()
        {
            var total = 0.00;
            var output = string.Empty;
            ConcatNumberAndAddToTotal(1, ref total, ref output, string.Empty);
            ConcatNumberAndAddToTotal(2, ref total, ref output, " + ");
            ConcatNumberAndAddToTotal(3, ref total, ref output, " + ");
            ConcatNumberAndAddToTotal(4, ref total, ref output, " + ");
            ConcatNumberAndAddToTotal(5, ref total, ref output, " + ");
            ConcatNumberAndAddToTotal(6, ref total, ref output, " + ");
            ConcatNumberAndAddToTotal(7, ref total, ref output, " + ");
            ConcatNumberAndAddToTotal(8, ref total, ref output, " + ");
            ConcatNumberAndAddToTotal(9, ref total, ref output, " + ");
            ConcatNumberAndAddToTotal(10, ref total, ref output, " + ");
            Console.WriteLine($"{output} = {total}");
        }


        /// <summary>
        /// Troca as posições de dois valores
        /// </summary>
        public static void Ex4()
        {
            var firstNumber = InputRequest.RequestDouble($"Introduza o 1º número");
            var secondNumber = InputRequest.RequestDouble($"Introduza o 2º número");
            var temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
            Console.WriteLine($"As posições foram trocadas. O 1º número agora é {firstNumber} e o 2º número é {secondNumber}");
        }

        /// <summary>
        /// Aplica a operação a+b*c a três valores
        /// </summary>
        public static void Ex5A()
        {
            var firstNumber = InputRequest.RequestDouble($"Introduza o 1º número");
            var secondNumber = InputRequest.RequestDouble($"Introduza o 2º número");
            var thirdNumber = InputRequest.RequestDouble($"Introduza o 3º número");
            var total = firstNumber + secondNumber * thirdNumber;
            Console.WriteLine($"{firstNumber} + {secondNumber} * {thirdNumber} = {total}");
        }

        /// <summary>
        /// Aplica a operação (-a)+b*c a três valores
        /// </summary>
        public static void Ex5B()
        {
            var firstNumber = InputRequest.RequestDouble($"Introduza o 1º número");
            var secondNumber = InputRequest.RequestDouble($"Introduza o 2º número");
            var thirdNumber = InputRequest.RequestDouble($"Introduza o 3º número");
            var total = (-1)*firstNumber + secondNumber * thirdNumber;
            Console.WriteLine($"-{firstNumber} + {secondNumber} * {thirdNumber} = {total}");
        }

        /// <summary>
        /// Aplica a operação (a+b)%c a três valores
        /// </summary>
        public static void Ex5C()
        {
            var firstNumber = InputRequest.RequestDouble($"Introduza o 1º número");
            var secondNumber = InputRequest.RequestDouble($"Introduza o 2º número");
            var thirdNumber = InputRequest.RequestDouble($"Introduza o 3º número");
            var total =  (firstNumber + secondNumber) % thirdNumber;
            Console.WriteLine($"({firstNumber} + {secondNumber}) % {thirdNumber} = {total}");
        }

        /// <summary>
        /// Aplica a operação a+b*c/d a quatro valores
        /// </summary>
        public static void Ex5D()
        {
            var firstNumber = InputRequest.RequestDouble($"Introduza o 1º número");
            var secondNumber = InputRequest.RequestDouble($"Introduza o 2º número");
            var thirdNumber = InputRequest.RequestDouble($"Introduza o 3º número");
            var fourthNumber = InputRequest.RequestDouble($"Introduza o 4º número");
            var total = firstNumber + secondNumber * thirdNumber / fourthNumber;
            Console.WriteLine($"{firstNumber} + {secondNumber} * {thirdNumber} / {fourthNumber} = {total}");
        }

        /// <summary>
        /// Aplica a operação a+b/c*d-e%f a seis valores
        /// </summary>
        public static void Ex5E()
        {
            var firstNumber = InputRequest.RequestDouble($"Introduza o 1º número");
            var secondNumber = InputRequest.RequestDouble($"Introduza o 2º número");
            var thirdNumber = InputRequest.RequestDouble($"Introduza o 3º número");
            var fourthNumber = InputRequest.RequestDouble($"Introduza o 4º número");
            var fifthNumber = InputRequest.RequestDouble($"Introduza o 5º número");
            var sixthNumber = InputRequest.RequestDouble($"Introduza o 6º número");
            var total = firstNumber + secondNumber / thirdNumber * fourthNumber - fifthNumber % sixthNumber;
            Console.WriteLine($"{firstNumber} + {secondNumber} / {thirdNumber} * {fourthNumber} - {fifthNumber} % {sixthNumber} = {total}");
        }

        /// <summary>
        /// Apresenta a tabuada para um número
        /// </summary>
        public static void Ex6()
        {
            var number = InputRequest.RequestInteger("Qual o número para a tabuada?");
            Console.WriteLine($"{number} x  1 = {number}");
            Console.WriteLine($"{number} x  2 = {number*2}");
            Console.WriteLine($"{number} x  3 = {number*3}");
            Console.WriteLine($"{number} x  4 = {number*4}");
            Console.WriteLine($"{number} x  5 = {number*5}");
            Console.WriteLine($"{number} x  6 = {number*6}");
            Console.WriteLine($"{number} x  7 = {number*7}");
            Console.WriteLine($"{number} x  8 = {number*8}");
            Console.WriteLine($"{number} x  9 = {number*9}");
            Console.WriteLine($"{number} x 10 = {number*10}");
        }

        /// <summary>
        /// Solicita dois números e apresenta a média
        /// </summary>
        public static void Ex7()
        {
            var fstNumber = InputRequest.RequestInteger("Qual o 1º número?");
            var sndNumber = InputRequest.RequestInteger("Qual o 2º número?");
            Console.WriteLine($"A média entre {fstNumber} e {sndNumber} é {((double)(fstNumber + sndNumber))/2}");
        }

        /// <summary>
        /// Solicita cinco números e apresenta a média
        /// </summary>
        public static void Ex8()
        {
            var counter = 0;
            var output = "A média entre";
            var total = 0.0;
            AddToTotalizerCountAndOutput(ref output, ref counter, ref total, string.Empty);
            AddToTotalizerCountAndOutput(ref output, ref counter, ref total, ", ");
            AddToTotalizerCountAndOutput(ref output, ref counter, ref total, ", ");
            AddToTotalizerCountAndOutput(ref output, ref counter, ref total, ", ");
            AddToTotalizerCountAndOutput(ref output, ref counter, ref total, "e ");
            Console.WriteLine($"{output} é {(total/counter)}");
        }

        /// <summary>
        /// Solicita dez números e apresenta a média
        /// </summary>
        public static void Ex9()
        {
            var counter = 0;
            var output = "A média entre";
            var total = 0.0;
            AddToTotalizerCountAndOutput(ref output, ref counter, ref total, string.Empty);
            AddToTotalizerCountAndOutput(ref output, ref counter, ref total, ", ");
            AddToTotalizerCountAndOutput(ref output, ref counter, ref total, ", ");
            AddToTotalizerCountAndOutput(ref output, ref counter, ref total, ", ");
            AddToTotalizerCountAndOutput(ref output, ref counter, ref total, ", ");
            AddToTotalizerCountAndOutput(ref output, ref counter, ref total, ", ");
            AddToTotalizerCountAndOutput(ref output, ref counter, ref total, ", ");
            AddToTotalizerCountAndOutput(ref output, ref counter, ref total, ", ");
            AddToTotalizerCountAndOutput(ref output, ref counter, ref total, ", ");
            AddToTotalizerCountAndOutput(ref output, ref counter, ref total, "e ");
            Console.WriteLine($"{output} é {(total / counter)}");
        }

        /// <summary>
        /// Solicitar um caracter e apresentar uma tabela 3x3 onde cada espaço é preenchido pelo caracter. 
        /// </summary>
        public static void Ex10()
        {
            var @char = InputRequest.RequestCharacter("Introduza um caracter");
            WriteCharacterThreeTimes(@char);
            WriteCharacterThreeTimes(@char);
            WriteCharacterThreeTimes(@char);
        }

        /// <summary>
        /// Solicitar um caracter e apresentar uma tabela 3x3 onde cada espaço é preenchido pelo caracter. 
        /// </summary>
        public static void Ex11()
        {
            var total = 0.0;
            var output = string.Empty;
            var counter = 1;
            RequestProduct(ref counter, ref total, ref output);
            RequestProduct(ref counter, ref total, ref output);
            RequestProduct(ref counter, ref total, ref output);
            RequestProduct(ref counter, ref total, ref output);
            RequestProduct(ref counter, ref total, ref output);
            Console.WriteLine($"{output}\nTotal - {total}");
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

        /// <summary>
        /// Concats a number to the output with a prefix, and adds the inputted value to a totalizer
        /// </summary>
        /// <param name="counter">just a number to notify the number's position'</param>
        /// <param name="total">the current total</param>
        /// <param name="output">the current output</param>
        /// <param name="prefix">the prefix that should be added</param>
        private static void ConcatNumberAndAddToTotal(int counter, ref double total, ref string output, string prefix)
        {
            var temp = InputRequest.RequestDouble($"Introduza o {counter}º número");
            total += temp;
            output += prefix + temp;
        }

        /// <summary>
        /// Adds a value to a totalizer, a counter and a string output
        /// </summary>
        /// <param name="output"></param>
        /// <param name="counter"></param>
        /// <param name="total"></param>
        /// <param name="prefix"></param>
        private static void AddToTotalizerCountAndOutput(ref string output, ref int counter, ref double total, string prefix)
        {
            counter++;
            var fstNumber = InputRequest.RequestInteger($"Qual o {counter}º número?");
            total += fstNumber;
            output += prefix + fstNumber;
        }

        /// <summary>
        /// Writes a character three times
        /// </summary>
        /// <param name="char">The character to be written</param>
        private static void WriteCharacterThreeTimes(char @char)
        {
            Console.WriteLine($"{@char} {@char} {@char}");
        }
    }
}
