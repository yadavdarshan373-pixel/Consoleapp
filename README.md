# Console App Practice Repository

A collection of beginner-friendly C# console applications built with .NET 10.

## Overview
This repository contains small console-based exercises for learning core C# concepts such as variables, conditions, loops, strings, arrays, methods, input validation, and date logic. Each project is designed to be run independently from its own folder.

## Available projects

| Project | Folder | Description | Run command |
| --- | --- | --- | --- |
| [Area & Perimeter](./Area&Perimeter/README.md) | `Area&Perimeter` | Calculates area and perimeter for basic shapes | `dotnet run --project ./Area&Perimeter/Area&Perimeter.csproj` |
| [BMI Calculator](./BMIcalculator/README.md) | `BMIcalculator` | Calculates BMI using different input styles and compares health classifications | `dotnet run --project ./BMIcalculator/BIMcalculator.csproj` |
| [Birthyear](./Birthyear/README.md) | `Birthyear` | Finds age-related details from a birth date | `dotnet run --project ./Birthyear/Birthyear.csproj` |
| [Calculator](./Calculator/README.md) | `Calculator` | Performs simple arithmetic operations with validation | `dotnet run --project ./Calculator/Calculator.csproj` |
| [Even/Odd Checker](./EvenOddCheck/README.md) | `EvenOddCheck` | Checks if a number is even or odd | `dotnet run --project ./EvenOddCheck/EvenOddCheck.csproj` |
| [Factorial Calculator](./FactorialCalculator/README.md) | `FactorialCalculator` | Computes factorials with number checks | `dotnet run --project ./FactorialCalculator/FactorialCalculator.csproj` |
| [FizzBuzz](./FizzBuzz/README.md) | `FizzBuzz` | Prints values according to FizzBuzz rules | `dotnet run --project ./FizzBuzz/FizzBuzz.csproj` |
| [Guess the Number](./GuesstheNumber/README.md) | `GuesstheNumber` | Lets the user guess a random number with hints | `dotnet run --project ./GuesstheNumber/GuesstheNumber.csproj` |
| [Hello User](./HelloUser/README.md) | `HelloUser` | Prints a welcome message using user input | `dotnet run --project ./HelloUser/HelloUser.csproj` |
| [Leap Year Detector](./LeapYearDetector/README.md) | `LeapYearDetector` | Checks whether a year is a leap year | `dotnet run --project ./LeapYearDetector/LeapYearDetector.csproj` |
| [Palindrome Checker](./PalindromeChecker/README.md) | `PalindromeChecker` | Verifies whether a word or sentence reads the same backward | `dotnet run --project ./PalindromeChecker/PalindromeChecker.csproj` |
| [Password Strength Checker](./PasswordStrengthChecker/README.md) | `PasswordStrengthChecker` | Evaluates password strength based on rules | `dotnet run --project ./PasswordStrengthChecker/PasswordStrengthChecker.csproj` |
| [Prime Number Checker](./PrimeNumberChecker/README.md) | `PrimeNumberChecker` | Determines if a number is prime | `dotnet run --project ./PrimeNumberChecker/PrimeNumberChecker.csproj` |
| [Reverse String](./ReverseString/README.md) | `ReverseString` | Reverses a string and shows the original result | `dotnet run --project ./ReverseString/ReverseString.csproj` |
| [Student Grade Manager](./StudentGradeManager/README.md) | `StudentGradeManager` | Practice project for grade-related logic and academic records | Manual exercise; no standalone project file is included yet |
| [Table Generator](./TableGenerator/README.md) | `TableGenerator` | Generates multiplication tables for a selected number | `dotnet run --project ./TableGenerator/TableCreator.csproj` |
| [Temperature Converter](./TemperatureConverter/README.md) | `TemperatureConverter` | Converts temperature values between common units | `dotnet run --project ./TemperatureConverter/TemperatureConverter.csproj` |
| [Vowel Count](./Vovelcount/README.md) | `Vovelcount` | Counts vowels in a string and shows the breakdown | `dotnet run --project ./Vovelcount/Vovelcount.csproj` |

> Note: The folder and file names are not fully consistent across all projects. The commands above use the exact project file names that exist in the repository.

## Requirements
- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- A terminal or command prompt

Check your installation:

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
├── Area&Perimeter/
├── BMIcalculator/
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
├── README.md
├── README_TEMPLATE.md
├── .gitignore
├── obj/
└── .git/
```

## Concepts practiced

These projects cover a range of beginner-to-intermediate C# topics, including:

- variables and data types
- arithmetic and comparison operators
- conditional statements
- loops and iteration
- methods and functions
- strings and character handling
- arrays and collections
- input validation
- date and time logic
- basic algorithm design and problem solving

## Roadmap

- add more real-world micro-projects
- improve naming consistency across folders and project files
- split logic into reusable helper files where useful
- add automated tests for common logic patterns
- explore file-based and database-driven examples

## Author

**Darshan Yadav**
- GitHub: [yadavdarshan373-pixel](https://github.com/yadavdarshan373-pixel)

---

This README serves as a repository index and quick guide for the available .NET console apps in this workspace.
