# 🎯 Number Guessing Game (C#)
![.NET](https://img.shields.io/badge/.NET-6.0-blue)
![C#](https://img.shields.io/badge/C%23-Programming-purple)
![Status](https://img.shields.io/badge/Status-Active-success)
![GitHub last commit](https://img.shields.io/github/last-commit/tarsidev/console-calculator)

A console-based number guessing game built with C# to practice programming fundamentals such as control flow, input validation, and clean code organization.

---

## 📌 Features

* 🎯 Random number generation based on difficulty
* 🎚️ Multiple difficulty levels:
  * Easy (0–10, 5 attempts)
  * Medium (0–50, 7 attempts)
  * Hard (0–100, 10 attempts)
* 🔁 Replay system (play again option)
* ✅ Input validation (numbers only)
* 📊 Attempt tracking
* 💬 Dynamic feedback (too high / too low)

---

## 🧪 Example Usage

```
=====================================
       NUMBER GUESSING GAME       
=====================================

Select Difficulty:

[1] Easy   (0–10, 5 attempts)
[2] Medium (0–50, 7 attempts)
[3] Hard   (0–100, 10 attempts)

Choose a difficulty: 2

-------------------------------------

Guess a number between 0 and 50

Attempts left: 7
> 25
Too high! Try again.

Attempts left: 6
> 10
Too low! Try again.

Attempts left: 5
> 18

Correct! You guessed the number in 3 attempts.

=====================================
       GAME OVER       
=====================================

Do you want to play again? (Y/N): Y
```

---

## 🧩 Key Concepts

* Input validation using loops
* Control flow with `while` and `do-while`
* Separation of concerns (GameEngine, InputValidator)
* Reusable methods and clean structure
* Boolean logic for game flow control

---

## 🧠 What I Learned

This project helped me practice:

* Structuring a C# console application
* Managing game loops and user interaction
* Validating and handling user input safely
* Organizing code into logical components
* Improving readability and user experience in CLI apps

---

## 🗂️ Project Structure

```
/number-guessing-game
│
├── Program.cs              # Entry point (starts the game loop)
├── /Game                   # Game logic and flow control
│   └── GameEngine.cs           
│
├── /Utils
│   └── InputValidator.cs   # Input validation and parsing
```

---

## ▶️ How to Run

1. Clone the repository:

   ```
   git clone https://github.com/tarsidev/number-guessing-game
   ```

2. Navigate to the project folder:

   ```
   cd number-guessing-game
   ```

3. Run the project:

   ```
   dotnet run
   ```

---

## 💡 Future Improvements

- [ ] Add difficulty validation (force valid selection)
- [ ] Implement a best score system
- [ ] Improve CLI visuals (colors, ASCII art)
- [ ] Add unit tests
- [ ] Refactor difficulty into a separate model/class

---

## 📖 About

This project is part of my journey learning C# and building small projects to strengthen my fundamentals and improve code structure and problem-solving skills.
