using System;
using System.Collections.Generic;

namespace higherOrderFunctions
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            // https://functionalprogrammingcsharp.com/higher-order-functions
            Func<int, int, int> add = (x, y) => x + y;
            int value = add(10, 2);
            Console.WriteLine(value);

            Dictionary<string, Func<int, int, int>> operations = new Dictionary<string, Func<int, int, int>>
            { 
                // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-initialize-a-dictionary-with-a-collection-initializer
                {"add", (x,y) => x+y},
                {"subtract", (x,y) => x-y},
                {"multiply", (x,y) => x*y},
                {"divide", (x,y) => x/y}
            };

            Func<int, int, int> operation = operations["add"];
            int result = operation(4, 5);
            Console.WriteLine(result);
        }
    }
}
