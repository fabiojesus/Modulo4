using System;
using Common;

namespace Consola
{
    internal class Menu
    {
        #region Singleton
        private static Menu _instance;
        private static readonly object Padlock = new object();

        private int CurrentLine { get; set; }

        private Menu() { }

        public static Menu Instance
        {
            get
            {
                lock (Padlock)
                {
                    return _instance ?? (_instance = new Menu());
                }
            }
        }

        #endregion


        public void Load()
        {
            Printer.PrintHeader("Welcome to Módulo 4", 2, 2,
                ConsoleColor.Yellow, ConsoleColor.Blue, '#');
            CurrentLine = Console.CursorTop;
        }

        public void RequestInput()
        {
            CurrentLine = Console.CursorTop;

        }

        public void ClearRequest()
        {
            var currentLine = Console.CursorTop;
            Console.CursorTop = CurrentLine;
            for (var rowCount = CurrentLine; rowCount < currentLine; rowCount++)
            {
                Console.CursorTop = rowCount;
                Console.CursorLeft = 0;
                Console.Write(new String(' ', Console.WindowWidth));
            }
            Console.CursorTop = CurrentLine;
            Console.CursorLeft = 0;
        }

    }
}
