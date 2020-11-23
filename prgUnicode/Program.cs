using System;

namespace prgUnicode
{
    class Program
    {
        static void Main(string[] args)
        {
            String unicodeString =
                "This Unicode string has 2 characters outside the" +
                "ASCII range: \n" +
                "Pi (\u03A0), and Sigma (\u03A3).";
            Console.WriteLine("Original string:");
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine(unicodeString);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Inserisci una frase:");
            Console.ReadLine();
        }
    }
}
