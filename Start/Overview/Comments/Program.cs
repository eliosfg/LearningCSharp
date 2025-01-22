using System;

namespace Comments
{
    class Program
    {
        /// XML Comments are used to help provide documentation
        /// They start with triple-slashes and have a special syntax
        /// <summary>
        /// This is the main simple application function
        /// </summary>
        /// <param name="args">An array of string arguments from the command line</param>
        /// <returns>
        /// No return value
        /// </returns>
        static void Main(string[] args)
        {
            // Single-line comments start with two slashes
            // You can have as many as you want
            Console.WriteLine("Hello World!");
            /* Multi-line comments start with a slash and asterisk
             * They can span multiple lines
             * And end with an asterisk and slash */
        }
    }
}
