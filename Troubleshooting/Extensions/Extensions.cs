using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Troubleshooting
{
    public static class Extensions
    {
        /// <summary>
        /// Exibe uma mensagem na console application
        /// </summary>
        /// <param name="message">message to be displayed</param>
        public static string Print(this string message)
        {
            Console.WriteLine(message);
            return message;
        }

        /// <summary>
        /// Exibe uma mensagem na output window do Visual Studio
        /// </summary>
        /// <param name="message">message to be displayed</param>
        public static void Output(this string message)
        {
            Debug.WriteLine(message);
        }
    }
}
