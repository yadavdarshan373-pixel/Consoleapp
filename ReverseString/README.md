# Reverse String

## Overview
This program takes a string from the user and reverses it character by character. It is a clear exercise in string manipulation, loops, and output formatting.

## Core C# concepts used
- Variables
- Strings
- Loops
- Character access
- Methods
- Console output

## How the program works
1. The user enters a string.
2. The original value is stored in a variable.
3. A loop iterates through the characters in reverse order.
4. The reversed string is built and displayed.

## Key logic explained
String reversal is a common beginner project because it reinforces how loops can transform text. Instead of changing the original value directly, the program builds a new result from the characters in reverse order.

```csharp
for (int i = text.Length - 1; i >= 0; i--)
{
    reversed += text[i];
}
```

## Learning takeaway
This project helps learners understand that strings can be processed one character at a time, which is a foundational idea in many real-world applications such as validation, parsing, and text processing.

## How to run
```bash
dotnet run --project ./ReverseString/ReverseString.csproj
```

## Requirements
- .NET 10 SDK
- A terminal or command prompt
