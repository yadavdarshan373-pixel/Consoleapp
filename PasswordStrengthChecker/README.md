# Password Strength Checker

## Overview
This project evaluates whether a password is weak, moderate, or strong by checking several common security rules. It is a practical example of validation logic in a real-life scenario.

## Core C# concepts used
- Variables
- Strings
- Character analysis
- Loops
- Conditional statements
- Boolean values
- Input validation

## How the program works
1. The user enters a password.
2. The program checks the length of the password.
3. It verifies whether the password contains uppercase, lowercase, numbers, and symbols.
4. It uses conditions to count how many rules are satisfied.
5. A final strength message is displayed.

## Key logic explained
This project is all about validation. It shows that a real program often needs to inspect every character in a string and decide whether a value meets a certain standard.

```csharp
bool hasUppercase = false;
bool hasLowercase = false;
bool hasDigit = false;

foreach (char ch in password)
{
    if (char.IsUpper(ch)) hasUppercase = true;
    if (char.IsLower(ch)) hasLowercase = true;
    if (char.IsDigit(ch)) hasDigit = true;
}
```

## Learning takeaway
This application demonstrates how loops, strings, and booleans work together to build meaningful validation logic. It is a strong beginner project for understanding data checking in real-world systems.

## How to run
```bash
dotnet run --project ./PasswordStrengthChecker/PasswordStrengthChecker.csproj
```

## Requirements
- .NET 10 SDK
- A terminal or command prompt
