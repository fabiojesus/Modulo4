using System;
using System.Collections.Generic;
using System.Text;
using Common;

namespace Worksheet10
{
    public class GroupThree
    {
        public static void Ex01()
        {
            var hours = InputRequest.RequestInteger("Quantas horas?");
            var minutes = InputRequest.RequestInteger("Quantos minutos?");
            var seconds = InputRequest.RequestInteger("Quantos segundos?");
            var total = hours * 3600 + minutes * 60 + seconds;
            Console.WriteLine($"{hours}:{minutes}:{seconds} é equivalente a {total} segundos");
        }

        public static void Ex02()
        {
            var radius = InputRequest.RequestDouble("Qual o raio?");
            var perimeter = 2 * 3.14 * radius;
            var area = 3.14 * radius * radius;
            Console.WriteLine($"A àrea do circulo é {area} e o perímetro é {perimeter}");
        }
    }
}
