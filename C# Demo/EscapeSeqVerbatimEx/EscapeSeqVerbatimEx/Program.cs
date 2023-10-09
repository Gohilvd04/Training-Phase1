using System.Reflection.Metadata;

namespace EscapeSeqVerbatimEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string location = "D:\\Vishal\\C# Learning"; //Escape sequence
            string locationX = @"D:\Vishal\C# Learning"; //Verbatim Literals

            Console.WriteLine(location);
            Console.WriteLine(locationX);

        }
    }
}