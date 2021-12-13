using System;
using ExtensionsApp_Core;
using ExtensionsApp_Core.Enums;

namespace ExtensionsApp_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //tl işareti için
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double dollar = 5.5;
            Console.WriteLine(Extens.UsdToTry(dollar));
            Console.ReadLine();
        }
    }
}