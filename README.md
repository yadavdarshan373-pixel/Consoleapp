# Console Apps

A collection of beginner-friendly C# console applications built with **.NET 10**.

## Table of contents
- [Overview](#overview)
- [Projects](#projects)
- [Requirements](#requirements)
- [Getting started](#getting-started)
- [Repository structure](#repository-structure)
- [Concepts practiced](#concepts-practiced)
- [Roadmap](#roadmap)
- [Author](#author)

## Overview
This repository contains small console-based programming exercises designed to practice core C# concepts such as variables, loops, conditionals, input validation, classes, arrays, and date/time logic. Each app is independent and can be run from its own project folder.

## Projects

| Project | Description | Run command |
|---------|-------------|------------|
| [Calculator](#calculator) | Performs basic arithmetic with a menu and validation | `dotnet run --project ./Calculator/Calculator.csproj` |
| [Guess the Number](#guess-the-number) | Random number guessing game with attempts and hints | `dotnet run --project ./GuesstheNumber/GuesstheNumber.csproj` |
| [Student Grade Manager](#student-grade-manager) | Calculates total, percentage, and grade for multiple subjects | Not yet runnable as a standalone project |
| [Birthyear](#birthyear) | Calculates age and days lived from a birth date | `dotnet run --project ./Birthyear/Birthyear.csproj` |
| [FizzBuzz](#fizzbuzz) | Prints custom divisor-based output rules through a chosen limit | `dotnet run --project ./FizzBuzz/FizzBuzz.csproj` |
| [Even/Odd Checker](#evenodd-checker) | Identifies even/odd numbers and counts them | `dotnet run --project ./EvenOddCheck/EvenOddCheck.csproj` |
| [Temperature Converter](#temperature-converter) | Converts Celsius, Fahrenheit, and Kelvin values | `dotnet run --project ./TemperatureConverter/TemperatureConverter.csproj` |
| [Factorial Calculator](#factorial-calculator) | Computes factorial values with validation | `dotnet run --project ./FactorialCalculator/FactorialCalculator.csproj` |
| [Leap Year Detector](#leap-year-detector) | Checks whether a year is leap year | `dotnet run --project ./LeapYearDetector/LeapYearDetector.csproj` |
| [Vowel Count](#vowel-count) | Counts vowels and shows the breakdown for A, E, I, O, and U | `dotnet run --project ./Vovelcount/Vovelcount.csproj` |
| [Reverse String](#reverse-string) | Reverses a user-entered string and shows the original and reversed output | `dotnet run --project ./ReverseString/ReverseString.csproj` |
| [Table Generator](#table-generator) | Generates a multiplication table for a chosen number | `dotnet run --project ./TableGenerator/TableCreator.csproj` |
| [Palindrome Checker](#palindrome-checker) | Verifies if a given string reads the same backward as forward | `dotnet run --project ./PalindromeChecker/PalindromeChecker.csproj` |
| [Prime Number Checker](#prime-number-checker) | Validates integers and applies O(√N) primality evaluation tests | `dotnet run --project ./PrimeChecker/PrimeChecker.csproj` |

---

### Project Summaries
The repository includes standard console apps ranging from basic arithmetic and conversions (Calculator, Temperature Converter) to string manipulations (Reverse String, Vowel Count, Palindrome Checker) and logic puzzles (FizzBuzz, Guess the Number, Prime Number Checker). Each project folder contains dedicated logic and configuration files.

## Requirements
- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- Verify installation:
```bash
dotnet --version
```

## Getting started
```bash
git clone https://github.com/yadavdarshan373-pixel/Consoleapp.git
cd Consoleapp
```

Then run any app you want:
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
├── LeapYearDetector/
├── PalindromeChecker/
├── PrimeChecker/
├── ReverseString/
├── StudentGradeManager/
├── TableGenerator/
├── TemperatureConverter/
├── Vovelcount/
├── .gitignore
├── README.md
└── obj/
```

## Concepts practiced
Projects cover fundamental C# programming concepts including methods, `switch` statements, loops, conditionals, string iteration, `Dictionary`, LINQ, and algorithmic optimization like O(√N) primality checks.

## Roadmap
- Add more real-world mini projects
- Split larger apps into model/service/helper files
- Improve project consistency across folders
- Add file-based persistence and data storage examples
- Add automated tests for common logic

---

## Author
**Darshan Yadav**
- GitHub: [yadavdarshan373-pixel](https://github.com/yadavdarshan373-pixel)

---

## 100-Day Project Ideas
A list of C# console application ideas for a 100-day coding challenge, organized by topic and difficulty, featuring completed milestones up to Day 14 and structured plans through Day 100.
