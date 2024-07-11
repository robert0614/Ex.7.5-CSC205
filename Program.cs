using System;

public class Test
{
    public static void Main()
    {
        // bool and char
        // Console.WriteLine(true + 'a'); // This will result in a compilation error

        // bool and int
        // Console.WriteLine(true + 1); // This will result in a compilation error

        // bool and string
        Console.WriteLine(true + "hello"); // Concatenation, result is string

        // char and int
        Console.WriteLine('a' + 1); // Addition, result is int

        // char and string
        Console.WriteLine('a' + "hello"); // Concatenation, result is string

        // int and string
        Console.WriteLine(1 + "hello"); // Concatenation, result is string

        // string and string
        Console.WriteLine("hello" + " world"); // Concatenation, result is string

        // int and int
        Console.WriteLine(1 + 1); // Addition, result is int
    }
}


/*
  
Output: 

truehello
98
ahello
1hello
hello world
2

*/



