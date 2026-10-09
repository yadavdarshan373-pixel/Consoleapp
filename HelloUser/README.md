# Hello User

A simple C# console app that asks for the user's name and welcomes them to C#.

## Description
This project demonstrates basic user input handling, validation, and string formatting in a console application.

## Features
- Prompts the user to enter their name
- Rejects empty input, spaces, or tabs
- Prints a personalized welcome message

## How it works
1. The program asks the user to enter a name.
2. It keeps asking until the input is not empty or whitespace.
3. It prints: `Hello <name> Welcome to C#!`

## Sample output
```bash
Enter your name: Rohit
Hello Rohit Welcome to C#!
```

## Run the program
```bash
dotnet run --project ./HelloUser/HelloUser.csproj
```

## Concepts practiced
- Variables
- User input
- String validation
- `while` loops
- String interpolation
