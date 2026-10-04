# Console Apps

A collection of small console applications built with C# and .NET 10.

## Projects

### Calculator

A menu-driven calculator for addition, subtraction, multiplication, and division.

Run it from the repository root:

```powershell
dotnet run --project .\Calculator\Calculator.csproj
```

### Guess the Number

A number-guessing game. The computer chooses a number from 1 to 100, and you have seven attempts to guess it. After each guess, the game tells you whether to guess higher or lower.

Run it from the repository root:

```powershell
dotnet run --project .\GuesstheNumber\GuesstheNumber.csproj
```

 Student Grade Manager
• Create a Student class with name and a List<int> of marks.
• Add 5 students in a List<Student>.
• Print each student's average and letter grade (switch).
• Print the top student.
Hint: Write GetAverage() inside Student, GetGrade(float) as a separate method, and track the
best in a foreach.

## Requirements

- .NET 10 SDK