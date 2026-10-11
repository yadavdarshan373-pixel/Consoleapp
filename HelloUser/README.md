# Hello User

## Overview
This is a beginner-friendly console app that greets the user by name. It is designed to help new programmers understand the simplest flow of a C# program: read input, store it, and show output.

## Core C# concepts used
- Variables
- Strings
- Console input/output
- Assignment operators
- Basic syntax

## How the program works
1. The program asks the user for their name.
2. The name is stored in a string variable.
3. The program combines the name with a greeting message.
4. The final message is displayed on the screen.

## Key logic explained
This app introduces the most basic building blocks of C#: variables, string handling, and console output. It is often the first step in learning how user input becomes visible output.

```csharp
string name = Console.ReadLine();
Console.WriteLine($"Hello, {name}!");
```

## Learning takeaway
Even a small project like this teaches the structure of a C# console application and helps learners understand input, variables, and output before moving to more advanced logic.

## How to run
```bash
dotnet run --project ./HelloUser/HelloUser.csproj
```

## Requirements
- .NET 10 SDK
- A terminal or command prompt
