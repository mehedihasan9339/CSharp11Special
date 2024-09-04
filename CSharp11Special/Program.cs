using System;
using System.Numerics;
using System.Text; // For INumber<T>

class Program
{
    static void Main()
    {
        // 1. List Patterns
        ProcessList(new[] { 1, 2, 3, 4 });

        // 2. Required Members
        var person = new Person { Name = "Alice", Age = 30 };
        Console.WriteLine($"Person: Name = {person.Name}, Age = {person.Age}");

        // 3. Raw String Literals
        var json = """
        {
            "name": "John",
            "age": 30
        }
        """;
        Console.WriteLine($"JSON: {json}");

        // 4. Generic Math
        Console.WriteLine($"Sum of 5 and 10: {Add(5, 10)}");
        Console.WriteLine($"Sum of 3.5 and 4.5: {Add(3.5, 4.5)}");

        // 5. Static Abstract Members in Interfaces
        Console.WriteLine($"Zero: {IntCalculator.Zero}, One: {IntCalculator.One}");

        // 6. UTF-8 Encoding and Decoding
        var originalString = "Hello, world!";
        var utf8Bytes = Encoding.UTF8.GetBytes(originalString);
        var decodedString = Encoding.UTF8.GetString(utf8Bytes);
        Console.WriteLine($"UTF-8 Encoded Bytes: {BitConverter.ToString(utf8Bytes)}");
        Console.WriteLine($"Decoded UTF-8 String: {decodedString}");

        // 7. nameof Expression Enhancements
        var example = new Example<int>();
        Console.WriteLine($"TypeName: {example.TypeName}");

        // 8. Enhanced `or` Patterns
        int value = 3;
        switch (value)
        {
            case 1 or 2:
                Console.WriteLine("Value is 1 or 2");
                break;
            case 3 or 4:
                Console.WriteLine("Value is 3 or 4");
                break;
            default:
                Console.WriteLine("Value is something else");
                break;
        }
    }

    // Helper method for Generic Math
    static T Add<T>(T a, T b) where T : INumber<T>
    {
        return a + b;
    }

    // Example of a class with required members
    public class Person
    {
        public required string Name { get; init; }
        public required int Age { get; init; }
    }

    // Example of static abstract members in an interface
    public interface ICalculable<T>
    {
        static abstract T Zero { get; }
        static abstract T One { get; }
    }

    public class IntCalculator : ICalculable<int>
    {
        public static int Zero => 0;
        public static int One => 1;
    }

    // Example of `nameof` expression enhancements
    public class Example<T>
    {
        public string TypeName => nameof(T);
    }

    // Example of List Patterns
    static void ProcessList(int[] numbers)
    {
        if (numbers is [1, 2, .. var rest])
        {
            Console.WriteLine($"Starts with 1, 2 and has {rest.Length} more elements.");
        }
        else
        {
            Console.WriteLine("Does not start with 1, 2.");
        }
    }
}
