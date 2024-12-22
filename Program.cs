using System;
using System.Runtime.InteropServices.JavaScript;
using CsharpFundamentals.Math;

namespace CsharpFundamentals
{
    class Program // Strings
    {
        static void Main(string[] args)
        {
            var firstName = "Rodney";
            var lastName = "Chery";
            
            var fullName = firstName + " " + lastName;
            
            var myFullName = string.Format("{0} {1}", firstName, lastName);
            
            var names = new string[3] { "Rodney", "Amos", "Chery"};
            var formattedNames = string.Join(", ", names);
            
            
            var text = @"Hi Rodney Amos Chery
 Look into the following path
c:\folder1\folder2\
c:\folder3\\folder4";
            Console.WriteLine(text);

        }
    }
}

