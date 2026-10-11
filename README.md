# Console Apps

A collection of beginner-friendly C# console applications built with .NET 10.

## Overview
This repository contains small console-based exercises that help practice core C# concepts such as variables, loops, conditionals, input validation, arrays, strings, classes, and date logic. Each project is kept independently runnable from its own folder.

## Projects

| Project | Folder | Description | Run command |
| --- | --- | --- | --- |
| [Calculator](./Calculator/README.md) | `Calculator` | Performs arithmetic operations with input validation | `dotnet run --project ./Calculator/Calculator.csproj` |
| [Birthyear](./Birthyear/README.md) | `Birthyear` | Calculates age and days lived from a birth date | `dotnet run --project ./Birthyear/Birthyear.csproj` |
| [Even/Odd Checker](./EvenOddCheck/README.md) | `EvenOddCheck` | Checks whether a number is even or odd and counts values | `dotnet run --project ./EvenOddCheck/EvenOddCheck.csproj` |
| [Factorial Calculator](./FactorialCalculator/README.md) | `FactorialCalculator` | Computes factorial values with validation | `dotnet run --project ./FactorialCalculator/FactorialCalculator.csproj` |
| [FizzBuzz](./FizzBuzz/README.md) | `FizzBuzz` | Prints output based on divisor rules up to a selected limit | `dotnet run --project ./FizzBuzz/FizzBuzz.csproj` |
| [Guess the Number](./GuesstheNumber/README.md) | `GuesstheNumber` | Lets the user guess a random number with hints and attempts | `dotnet run --project ./GuesstheNumber/GuesstheNumber.csproj` |
| [Hello User](./HelloUser/README.md) | `HelloUser` | Simple greeting app that demonstrates basic console input/output | `dotnet run --project ./HelloUser/HelloUser.csproj` |
| [Leap Year Detector](./LeapYearDetector/README.md) | `LeapYearDetector` | Checks whether a year is a leap year | `dotnet run --project ./LeapYearDetector/LeapYearDetector.csproj` |
| [Palindrome Checker](./PalindromeChecker/README.md) | `PalindromeChecker` | Verifies whether a string reads the same backward and forward | `dotnet run --project ./PalindromeChecker/PalindromeChecker.csproj` |
| [Password Strength Checker](./PasswordStrengthChecker/README.md) | `PasswordStrengthChecker` | Evaluates password strength based on length and character rules | `dotnet run --project ./PasswordStrengthChecker/PasswordStrengthChecker.csproj` |
| [Prime Number Checker](./PrimeNumberChecker/README.md) | `PrimeNumberChecker` | Tests if a number is prime using a simple optimization | `dotnet run --project ./PrimeNumberChecker/PrimeNumberChecker.csproj` |
| [Reverse String](./ReverseString/README.md) | `ReverseString` | Reverses user input and displays the original and reversed strings | `dotnet run --project ./ReverseString/ReverseString.csproj` |
| [Student Grade Manager](./StudentGradeManager/README.md) | `StudentGradeManager` | Example grade calculation project for academic records | Run manually as a learning exercise |
| [Table Generator](./TableGenerator/README.md) | `TableGenerator` | Generates multiplication tables for a chosen number | `dotnet run --project ./TableGenerator/TableCreator.csproj` |
| [Temperature Converter](./TemperatureConverter/README.md) | `TemperatureConverter` | Converts between Celsius, Fahrenheit, and Kelvin | `dotnet run --project ./TemperatureConverter/TemperatureConverter.csproj` |
| [Vowel Count](./Vovelcount/README.md) | `Vovelcount` | Counts vowels in a string and shows the breakdown | `dotnet run --project ./Vovelcount/Vovelcount.csproj` |

## Requirements
- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- Confirm that the SDK is installed:

```bash
dotnet --version
```

## Getting started

```bash
git clone https://github.com/yadavdarshan373-pixel/Consoleapp.git
cd Consoleapp
```

Run any project from the repository root:

```bash
dotnet run --project ./Calculator/Calculator.csproj
```

## Repository structure

```text
Consoleapp/
├── Birthyear/
├── Calculator/
├── EvenOddCheck/
├── FactorialCalculator/
├── FizzBuzz/
├── GuesstheNumber/
├── HelloUser/
├── LeapYearDetector/
├── PalindromeChecker/
├── PasswordStrengthChecker/
├── PrimeNumberChecker/
├── ReverseString/
├── StudentGradeManager/
├── TableGenerator/
├── TemperatureConverter/
├── Vovelcount/
├── .gitignore
├── README.md
├── obj/
└── .git/
```

## Concepts practiced

These projects cover a range of beginner-to-intermediate C# topics including:

- variables and data types
- conditional statements
- loops and iteration
- methods and functions
- string manipulation
- arrays and collections
- input validation
- date/time handling
- basic algorithms and problem solving

## Roadmap

- add more real-world mini projects
- split larger logic into helper/service files
- improve consistency across project naming and structure
- add automated tests for utilities and logic
- explore file-based data persistence examples

## Author

**Darshan Yadav**
- GitHub: [yadavdarshan373-pixel](https://github.com/yadavdarshan373-pixel)

---

This README is intended to serve as a project index for the repository and a quick way to discover available .NET console apps and their commands.
