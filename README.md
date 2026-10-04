# Console Apps

A collection of beginner-friendly console applications built with C# and .NET 10.

## Table of contents
- [Projects](#projects)
- [Requirements](#requirements)
- [Getting started](#getting-started)
- [Repository structure](#repository-structure)
- [Concepts practiced](#concepts-practiced)
- [Roadmap](#roadmap)
- [Author](#author)

## Projects

| Project | Description | Key concepts |
|---------|-------------|--------------|
| [Calculator](#1-calculator) | Menu-driven calculator | Methods, `switch`, input validation |
| [Guess the Number](#2-guess-the-number) | Number-guessing game | Loops, `Random`, conditions |
| [Student Grade Manager](#3-student-grade-manager) | Student result report | Classes, `Dictionary`, LINQ, `switch` |

---

### 1. Calculator
A menu-driven calculator that performs basic arithmetic.

Features:
- Menu with 4 operations: addition, subtraction, multiplication and division
- Reads two numbers from the user and prints the result
- Handles invalid input and division by zero without crashing

How it works:
1. The menu is displayed
2. The user selects an operation
3. The user enters the numbers
4. The program calculates and prints the result

Sample run:
```
===== Calculator =====
1. Addition
2. Subtraction
3. Multiplication
4. Division
Choose an option: 1
Enter first number: 12
Enter second number: 8
Result: 20
```

Run:
```bash
dotnet run --project ./Calculator/Calculator.csproj
```

---

### 2. Guess the Number
A number-guessing game. The computer picks a random number from 1 to 100, and you have 7 attempts to guess it.

Features:
- Random number generated with the `Random` class
- Maximum of 7 attempts
- Hint after every wrong guess: "Too high" or "Too low"
- Win or lose message at the end, with the correct number revealed on a loss

How it works:
1. The computer picks a number from 1 to 100
2. The player enters a guess
3. The game gives a higher or lower hint
4. The loop repeats until the player guesses correctly or runs out of attempts

Sample run:
```
I have picked a number from 1 to 100. You have 7 attempts.
Attempt 1: 50
Too low, guess higher.
Attempt 2: 75
Too high, guess lower.
Attempt 3: 63
Correct! You guessed it in 3 attempts.
```

Run:
```bash
dotnet run --project ./GuesstheNumber/GuesstheNumber.csproj
```

---

### 3. Student Grade Manager
Reads a student's name and roll number, then the marks of 5 subjects. It calculates the total, percentage and grade and prints a formatted report.

Features:
- Subjects and marks stored in a `Dictionary<string, int>`
- Total calculated with LINQ (`Subject.Values.Sum()`)
- Percentage and grade calculated with a `switch`
- Input validation: roll number above 0, no empty or duplicate subject names, marks from 0 to 100

Grading system:

| Percentage | Grade |
|------------|-------|
| 90 - 100 | A |
| 80 - 89 | B |
| 60 - 79 | C |
| 40 - 59 | D |
| Below 40 | Fail |

How it works: the percentage is divided by 10 and cast to `int` (e.g. 83.0 becomes 8), then a `switch` picks the grade for that band.

Sample output:
```
-----------------------------------
Name            : Rahul
Roll Number     : 101
-----------------------------------
Subject          Marks
Maths           90
Science         85
English         78
Hindi           70
Computer        92
-----------------------------------
Total           :415/500
-----------------------------------
Percentage      :83.00%
-----------------------------------
Grade           :B
-----------------------------------
```

Run:
```bash
dotnet run --project ./StudentGradeManager/StudentGradeManager.csproj
```

---

## Requirements
- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- Check your installation:
```bash
dotnet --version
```

## Getting started
```bash
git clone https://github.com/yadavdarshan373-pixel/Consoleapp.git
cd Consoleapp
dotnet run --project ./Calculator/Calculator.csproj
```
Replace the project path to run any other app.

## Repository structure
```
Consoleapp/
├── Calculator/
├── GuesstheNumber/
├── StudentGradeManager/
├── .gitignore
└── README.md
```

## Concepts practiced

| Project | Concepts |
|---------|----------|
| Calculator | Methods, `switch`, `int.TryParse()`, input validation |
| Guess the Number | `Random`, loops, conditions, attempt counter |
| Student Grade Manager | Classes, `const`, `Dictionary`, LINQ, `switch`, string formatting (`:F2`, `{item,-15}`) |

## Roadmap
- Add more mini projects (to-do list, bank account, quiz)
- Split larger projects into separate files (Models, Services, Helpers)
- Support multiple students in Student Grade Manager
- Save and load data from files (JSON or CSV)
- Add unit tests

## Author
Darshan Yadav

- GitHub: [yadavdarshan373-pixel](https://github.com/yadavdarshan373-pixel)
