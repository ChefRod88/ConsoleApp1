using System;
using System.Runtime.InteropServices.JavaScript;
using CsharpFundamentals.Math;

namespace CsharpFundamentals
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express= 3
    }
    
    class Program // Enums
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method); // type cast enum to an integer

            var methodID = 3;
            Console.WriteLine((ShippingMethod)methodID);
            
            Console.WriteLine(method.ToString());
            
            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            
        }
    }
}

