using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); // outputs Hello World 

            int number = 2; // Variables, I can declare the datatype or I can use var and it will be detected automatically
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'a';
            var name = "Rodney";
            var isWorking = false;
            
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(name);
            Console.WriteLine(isWorking);
        }
    }
}