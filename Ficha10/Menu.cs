using System;
using System.Collections.Generic;
using System.Text;
using Common;

namespace Ficha10
{
    public class Menu
    {
        public static void DisplayMain()
        {
            Printer.PrintList(new []{"Grupo 1", "Grupo 2", "Grupo 3", "Voltar"}, true);
            while (true)
            {
                var opt = InputRequest.RequestString("Seleccione um grupo");
                switch (opt)
                {
                    case "1": DisplaySub("G1"); break;
                    case "2": DisplaySub("G2"); break;
                    case "3": DisplaySub("G3"); break;
                    case "4": return;
                    default: continue;
                }
            }
        }

        public static void DisplaySub(string group)
        {

        }


        public static void Run(string ex)
        {
            switch (ex)
            {
                case "G1E01": F10G1.Ex1();break;
                case "G1E02": F10G1.Ex2();break;
                case "G1E03": F10G1.Ex3();break;
                case "G1E04": F10G1.Ex4();break;
                case "G1E5a": F10G1.Ex5A();break;
                case "G1E5b": F10G1.Ex5B();break;
                case "G1E5c": F10G1.Ex5C();break;
                case "G1E5d": F10G1.Ex5D();break;
                case "G1E5e": F10G1.Ex5E();break;
                case "G1E06": F10G1.Ex6(); break;
                case "G1E07": F10G1.Ex7(); break;
                case "G1E08": F10G1.Ex8(); break;
                case "G1E09": F10G1.Ex9(); break;
                case "G1E10": F10G1.Ex10(); break;
                case "G2E01": F10G2.Ex1(); break;
                case "G2E02": F10G2.Ex2(); break;
                case "G2E03": F10G2.Ex3(); break;
                case "G3E01": F10G3.Ex1(); break;
                case "G3E02": F10G3.Ex2(); break;
                default:Console.WriteLine(""); break;
            }
        }
    }
}
