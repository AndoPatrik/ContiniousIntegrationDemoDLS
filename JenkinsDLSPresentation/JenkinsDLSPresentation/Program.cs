using System;

namespace JenkinsDLSPresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Calculator!");
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(5,10));
            Console.WriteLine(calculator.Substract(50,10));
            Console.ReadKey();
        }
    }
}
