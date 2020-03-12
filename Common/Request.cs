using System;

namespace Common
{
    public class InputRequest
    {
        /// <summary>
        /// Requests an input for an integer value
        /// </summary>
        /// <param name="message">The message that should be presented to the user</param>
        /// <returns>The inputted value or 0 by default</returns>
        public static int RequestInteger(string message)
        {
            int.TryParse(RequestString(message), out var @int);
            return @int;
        }

        /// <summary>
        /// Requests an input for an double value
        /// </summary>
        /// <param name="message">The message that should be presented to the user</param>
        /// <returns>The inputted value or 0.00 by default</returns>
        public static double RequestDouble(string message)
        {
            double.TryParse(RequestString(message), out var @double);
            return @double;
        }

        /// <summary>
        /// Requests an input for an character value
        /// </summary>
        /// <param name="message">The message that should be presented to the user</param>
        /// <returns>The first character in the inputted value or '' by default</returns>
        public static char RequestCharacter(string message)
        {
            var res = RequestString(message);
            return res[0];
        }

        /// <summary>
        /// Requests an input for an text value
        /// </summary>
        /// <param name="message">The message that should be presented to the user</param>
        /// <returns>The inputted value or "" by default</returns>
        public static string RequestString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}
