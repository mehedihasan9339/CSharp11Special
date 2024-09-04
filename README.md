# C# 11 Features Demo

This repository contains a console application demonstrating various new features introduced in C# 11. The application is built using .NET 8.0 and provides practical examples of these language enhancements.

## Features Demonstrated

### 1. List Patterns

C# 11 introduces list patterns for matching and deconstructing lists and arrays. This feature allows you to match against specific patterns within lists or arrays.

- **Example**: `ProcessList` method checks if an array starts with `[1, 2]` and captures the remaining elements using `.. var rest`.

### 2. Required Members

The `required` modifier ensures that certain properties are initialized when creating an object. This enforces required initialization of object members.

- **Example**: `Person` class requires `Name` and `Age` properties to be initialized at object creation.

### 3. Raw String Literals

Raw string literals allow multi-line strings to be written more clearly, without needing to escape special characters.

- **Example**: The `json` variable demonstrates a raw string literal representing a JSON structure.

### 4. Generic Math

The `INumber<T>` interface allows performing arithmetic operations on generic numeric types in a type-safe manner.

- **Example**: `Add` method uses `INumber<T>` to add two numbers of any numeric type, such as integers and doubles.

### 5. Static Abstract Members in Interfaces

C# 11 allows interfaces to define static abstract members that implementing types must provide. This enhances flexibility and abstraction in generic programming.

- **Example**: `ICalculable<T>` interface defines static abstract members `Zero` and `One`, implemented by `IntCalculator` class.

### 6. UTF-8 Encoding and Decoding

Handling UTF-8 encoding and decoding is made easier, though direct UTF-8 string literals are experimental. This feature demonstrates encoding and decoding strings using UTF-8.

- **Example**: `originalString` is encoded to UTF-8 bytes and then decoded back to a string.

### 7. `nameof` Expression Enhancements

The `nameof` operator has been enhanced to support more contexts, including generic type parameters.

- **Example**: `Example<T>` class uses `nameof` to get the name of the generic type parameter `T`.

### 8. Enhanced `or` Patterns

Enhanced `or` patterns in `switch` statements allow handling multiple case values more concisely and clearly.

- **Example**: The `switch` statement uses `or` patterns to handle multiple values (`1 or 2`, `3 or 4`).



<hr>

<p align="center">
  Developer: <a href="mailto:mehedihasan9339@gmail.com">Mehedi Hasan</a>
</p>
