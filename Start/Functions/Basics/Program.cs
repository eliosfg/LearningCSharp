using System;

// Functions are used to group re-usable code together in a single
// unit that can be customized with parameters.

// TODO: Functions have a return type, name, and optional parameters
float MilesToKilometers(float miles)
{
    return miles * 1.60934f;
}

// TODO: A function with no return value has a 'void' type
void PrintWithPrefix(string str)
{
    Console.WriteLine($"::> {str}");
}

// TODO: Call first function
Console.WriteLine($"The result is: {MilesToKilometers(8.0f)}");
Console.WriteLine($"The result is: {MilesToKilometers(52):F3}");

// TODO: Call second function
PrintWithPrefix("Test String");
PrintWithPrefix("Another Test String");