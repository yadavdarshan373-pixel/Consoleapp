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
| [Birthyear](#4-birthyear) | Calculates birth year, age, and days lived | `DateOnly`, tuples, input validation |

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

### 4. Birthyear
A console app that calculates a person's birth year, age, and total days lived from their date of birth.

Run:
```bash
dotnet run --project ./Birthyear/Birthyear.csproj
```

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

## 100-Day Project Ideas

A list of C# console application ideas for a 100-day coding challenge, organized by topic and difficulty.
------------------------------
## 🟢 Days 1–15: Core Basics (Variables, Loops, Conditions)
Focus on syntax, simple data types, logic control, and user input validation.

* Day 1: Hello User: Ask for a name and age, then calculate the user's birth year.
* Day 2: Simple Calculator: Perform basic arithmetic (+, -, *, /) with clean user input prompts.
* Day 3: Odd or Even: Accept a series of numbers and identify which ones are odd or even.
* Day 4: Temperature Converter: Convert values back and forth between Celsius, Fahrenheit, and Kelvin.
* Day 5: FizzBuzz: Loop from 1 to 100, printing "Fizz", "Buzz", or "FizzBuzz" based on divisibility.
* Day 6: Factorial Calculator: Calculate the factorial of a given integer using a standard loop.
* Day 7: Multiplication Table Generator: Generate a clean, aligned mathematical table for any chosen number.
* Day 8: Leap Year Checker: Determine if a given year is a leap year using logical operations.
* Day 9: Vowel and Consonant Counter: Read a string and count how many vowels and consonants it contains.
* Day 10: String Reverser: Reverse a string entered by the user without using built-in array operations.
* Day 11: Number Guessing Game: The user guesses a computer-generated secret number with "high/low" hints.
* Day 12: Basic BMl Calculator: Calculate Body Mass Index based on height and weight inputs.
* Day 13: Area & Perimeter Finder: Compute areas for rectangles, circles, and triangles based on user choices.
* Day 14: Simple Timer: Count down from a specific number of seconds with a visual pause (Thread.Sleep).
* Day 15: Unit Converter: Convert distances (Meters to Feet, Kilometres to Miles).

------------------------------
## 🔵 Days 16–35: Data Structures & Collections (Arrays, Lists, Dictionaries)
Focus on data storage, sorting, indexing, and in-memory data management.

* Day 16: To-Do List Tracker: Add, view, and mark tasks as complete using an in-memory List<string>.
* Day 17: Shopping Cart Simulation: Add items and prices to a cart, calculate the total tax, and print a receipt.
* Day 18: Student Gradebook: Calculate the class average, highest score, and lowest score using an array.
* Day 19: Phonebook Directory: Save names and phone numbers inside a Dictionary<string, string> for quick lookups.
* Day 20: Array Min/Max Finder: Find the largest and smallest numbers in a user-defined numeric array.
* Day 21: Unique Word Finder: Accept a paragraph of text and extract only the unique words.
* Day 22: Dice Roller Simulator: Simulate rolling a pair of six-sided dice multiple times and track frequency.
* Day 23: Morse Code Translator: Convert plain text strings into Morse code representations.
* Day 24: Rock, Paper, Scissors: Play a multi-round match against a randomized computer opponent.
* Day 25: Simple Word Counter: Parse a sentence to accurately count the total number of words.
* Day 26: Palindrome Checker: Test if a word or phrase reads the same backward as forward.
* Day 27: Anagram Validator: Compare two strings to check if they are anagrams of each other.
* Day 28: Basic Inventory Stock Tracker: Store item IDs and current quantities, allowing updates.
* Day 29: Grade Classifier: Map numeric scores to traditional letter grades (A, B, C, etc.).
* Day 30: Card Shuffler: Create an array representing a standard deck and randomize the card order.
* Day 31: Frequency Map: Count how many times each character or number appears in a user input dataset.
* Day 32: List Merger: Combine two separate numeric lists, sort them, and remove duplicate values.
* Day 33: Random Name Picker: Pick a lucky winner out of an array of submitted names.
* Day 34: Simple Matrix Addition: Work with two-dimensional arrays to add two 3x3 matrices.
* Day 35: High Score Leaderboard: Maintain a top-5 list of scores, automatically shifting positions when beaten.

------------------------------
## 🟡 Days 36–55: Object-Oriented Programming (Classes, Methods, OOP)
Focus on structuring clean code using objects, custom classes, constructors, and encapsulation.

* Day 36: Bank Account Simulator: Build a class managing Deposit(), Withdraw(), and balance properties.
* Day 37: Library Management Tracker: Model a library with Book and Member objects to manage checkouts.
* Day 38: Vehicle Inheritance Tree: Create a base Vehicle class with inherited Car and Motorcycle behaviors.
* Day 39: Employee Payroll System: Track hourly vs. salaried employees using polymorphism.
* Day 40: Digital Product Store: Model items with discounts, applying explicit taxonomy using interfaces.
* Day 41: RPG Character Creator: Design a character class with base stats (Health, Mana, Strength).
* Day 42: Geometry Shape Calculator: Use abstract classes to find the area of different dynamic shapes.
* Day 43: Cinema Ticket Booking: Manage standard vs. VIP seating grids using dedicated class instances.
* Day 44: Pet Care Simulator: Keep a digital pet happy by calling distinct interactive feeding and playing methods.
* Day 45: Recipe Box: Store objects representing recipes containing arrays of ingredients and directions.
* Day 46: School Management System: Manage collections of Student, Teacher, and Course classes.
* Day 47: Vehicle Rental System: Calculate rental rates dynamically depending on the selected vehicle type.
* Day 48: Hotel Room Booking: Track occupancy statuses and calculate checkout prices over multiple nights.
* Day 49: Fleet Tracker: Manage delivery trucks with varying mileage tracking and maintenance alerts.
* Day 50: Flight Reservation Board: Create flights with distinct capacities, seating types, and price calculations.
* Day 51: Smart Home Device Controller: Represent smart lights and stats via inherited device base classes.
* Day 52: Medical Clinic Appointment Scheduler: Model doctors, patients, and open booking slots.
* Day 53: E-Commerce Order Processor: Track orders moving through processing states (Pending, Shipped, Delivered).
* Day 54: Coffee Shop Point of Sale: Choose a base drink and customize it dynamically using object properties.
* Day 55: Music Playlist Manager: Model single songs and control linear skipping/shuffling playback logic.

------------------------------
## 🟠 Days 56–75: File Handling, Serialization & LINQ
Focus on data persistence (saving/loading files) and writing elegant queries with Language Integrated Query (LINQ).

* Day 56: Plain Text Logger: Write dated error and activity logs cleanly out to a .txt file.
* Day 57: CSV Contact Directory: Save names, emails, and phone numbers directly to a comma-separated file.
* Day 58: JSON Notes App: Save, view, and read dynamic daily notes to disk via JSON parsing.
* Day 59: LINQ Grade Filter: Filter a massive array of student scores to find top performers using LINQ expressions.
* Day 60: File Backupper: Copy all matching text assets from a source folder into a destination backup folder.
* Day 61: XML Configuration Parser: Read external application configuration variables out of an XML file.
* Day 62: Expense Tracker (JSON): Log incoming expenses with categories and save them dynamically to disk.
* Day 63: Password Vault (Local File): Save website log-in records into a file using a makeshift custom cipher.
* Day 64: Inventory Reporter: Query an array of products to find items falling under a safe threshold.
* Day 65: Directory File Analyzer: Scan a folder to report back total file counts, sizes, and file type distributions.
* Day 66: Word Finder (Grep-lite): Search multiple files in a folder for a targeted word string match.
* Day 67: Log File Aggregator: Read a large application log file and group errors by their severity rating.
* Day 68: User Auth Storage System: Maintain a text file containing secure usernames and hashed password inputs.
* Day 69: Sales Projection Calculator: Read raw monthly numbers from a text file to compute sales trends.
* Day 70: CSV to JSON Converter: Parse a comma-delimited data file and re-output it formatted as structural JSON.
* Day 71: Task Reminders System: Read a tasks file on launch and print immediate warnings for high-priority entries.
* Day 72: Advanced Data Filter: Group a custom dataset by city and extract the oldest entry using LINQ.
* Day 73: Recipe Exporter: Format recipe object data into a clean text sheet ready for print.
* Day 74: File Encryption Utility: Read a local file, shift its text contents using a simple key, and save it.
* Day 75: File Decryption Utility: Reverse the encryption process from Day 74 using the correct key file.

------------------------------
## 🔴 Days 76–90: Text Games & Complex Logic
Focus on algorithms, state engines, game loops, and custom console UI generation.

* Day 76: Interactive Tic-Tac-Toe: A 2-player board game drawn in the console with win-checking grids.
* Day 77: Text Adventure Game: A basic choose-your-own-adventure story mapping branch choices.
* Day 78: Hangman: The complete game including visual drawing steps of the gallows character.
* Day 79: Console Blackjack: Play a match against an automated dealer using actual casino math constraints.
* Day 80: Sudoku Board Validator: Verify whether a filled 9x9 number grid satisfies the rules of Sudoku.
* Day 81: Connect Four: Drop game chips into a vertical, multi-column board grid array.
* Day 82: Turn-Based Combat Arena: Battle monsters with status modifiers (poison, critical hits, blocking).
* Day 83: Minesweeper (Basic Grid): Reveal blocks on a hidden matrix board avoiding randomly placed mines.
* Day 84: Basic Chess Engine Layout: Display a board layout tracking legal linear movement paths for a Rook.
* Day 85: Snake (ASCII): Drive an ASCII snake character across the screen updating text coordinates.
* Day 86: Trivia Quiz Engine: Load multi-tier trivia cards with timed responses from an external JSON file.
* Day 87: Virtual Stock Market Game: Buy/sell fake shares with shifting values updating over mock intervals.
* Day 88: Text-Based Maze Solver: Find the exit path out of an ASCII-walled text maze block map.
* Day 89: Typing Speed Test: Track typing speed (Words Per Minute) and flag specific spelling spelling errors.
* Day 90: Tower of Hanoi: Solve the classic puzzle by tracking disk shifts across stack arrays.

------------------------------
## 🔥 Days 91–100: Advanced Utilities, Regex & APIs
Focus on modern .NET libraries, regular expressions, basic APIs, error catching, and asynchronous tasks.

* Day 91: RegEx Email Extractor: Scan strings or messy documents using regex to find valid email structures.
* Day 92: Basic Web Scraper: Download a webpage source string via HttpClient and parse text metadata.
* Day 93: Currency Exchange Live Fetcher: Pull currency rates from a free API endpoint using an active web client.
* Day 94: Async File Downloader: Download web data bundles into a file utilizing standard async/await patterns.
* Day 95: Weather Console Dashboard: Pull local temperature conditions from a free public API endpoint.
* Day 96: Markdown to HTML Parser: Read simple files matching tags like # or ** to generate valid HTML code blocks.
* Day 97: IP Address Validator: Parse input strings to check if they match functional IPv4 network specifications.
* Day 98: Custom In-App Task Queue: Run tasks on multiple background threads to simulate multi-threaded processing.
* Day 99: Console Progress Bar: Build a dynamic, reusable loading graphic ([=====➔ ] 50%) that updates inline.
* Day 100: Full Capstone Mini-ERP: Combine a file database, API rates, and inventory logic into a master system.

------------------------------
Would you like me to generate a structured calendar layout for these 100 days, or should we write the complete source code for Day 1 to get your challenge started?

