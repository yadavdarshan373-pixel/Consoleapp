# BMI Calculator

## Overview
This project calculates Body Mass Index (BMI) using metric and imperial height and weight inputs. It also displays classifications using global and Asian/Indian BMI ranges.

## Core C# concepts used
- Variables and numeric data types
- Arithmetic operators and formulas
- `switch` statements
- Conditional statements
- `while` loops
- Console input/output
- Input validation and numeric formatting

## How the program works
1. The user chooses one of four height and weight unit combinations.
2. The program prompts for height and weight, repeating the prompts until positive numeric values are entered.
3. It calculates BMI using the formula for the selected units.
4. It displays the BMI rounded to two decimal places and its classifications under both sets of ranges.

## Key logic explained
The calculator selects a BMI formula based on the units entered. For example, with height in centimeters and weight in kilograms, it multiplies the weight-to-height-squared ratio by 10,000.

```csharp
bmi = weight / (height * height) * 10000;
```

## Learning takeaway
This project shows how input validation, branching, and arithmetic can work together to handle multiple input formats and report a result.

## How to run
```bash
dotnet run --project ./BIMcalculator/BIMcalculator.csproj
```

## Requirements
- .NET 10 SDK
- A terminal or command prompt
