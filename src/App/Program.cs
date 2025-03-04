using Ext;

namespace App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        
        static void Main()
        {
            var c = new Class1();
            var bin = c.Test();

            Console.WriteLine("test " + bin.ToString());
        }
    }
}