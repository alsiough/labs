using System;
using StringLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            StringArray str1 = new StringArray();

            
            StringArray str2 = new StringArray("123456789");

            Console.WriteLine("length str2: " + str2.Length());

            
            str2.RemoveChar('5');
            Console.WriteLine("line after delete '5': " + str2.GetData());
        }
    }
}
