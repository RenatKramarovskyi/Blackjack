# Blackjack Console Application

This is a simple console-based Blackjack game implemented in C#. Below are the details of the program's functionality and how to run it locally.

## Functionality

The Blackjack game allows players to play rounds of Blackjack against a dealer. The player can hit (draw a card) or stand (end their turn) to compete against the dealer. The game includes basic scoring logic and determines the winner based on Blackjack rules.

## How to Run Locally
To run the Blackjack console application locally, follow these steps:

### Clone Repository

```bash
https://github.com/RenatKramarovskyi/Blackjack
```

### Open Solution
Open the solution in Visual Studio or your preferred C# IDE.

### Build and Run

To run the Blackjack console application, follow these steps:

1. **Build the Solution:**
   Build the solution in your IDE.

2. **Start the Program:**
   Run the program from your IDE.

## Follow On-Screen Instructions

During gameplay, use the numeric options presented on the console to navigate through the menu and play Blackjack.

## Programming Principles

The project adheres to the following programming principles:

- **Single Responsibility Principle (SRP):**
  Each class and method has a single responsibility, such as managing hands, managing the deck, or handling game logic.

- **Open/Closed Principle (OCP):**
  The game logic is designed to be extensible without modifying existing code, allowing for easy addition of new features.

- **Liskov Substitution Principle (LSP):**
  Polymorphism is used in handling different types of cards and hands, maintaining the substitutability of objects.

- **Dependency Inversion Principle (DIP):**
  Dependency injection is employed to pass dependencies to objects, reducing tight coupling between components.

- **Don't Repeat Yourself (DRY):**
  Repeated code segments have been refactored into methods to promote maintainability.

## Design Patterns

Design patterns utilized in this project include:

- **Factory Method Pattern:**
  Used to create different types of cards (`BlackjackCard`) and hands (`BlackjackHand`) without exposing the creation logic.

- **Strategy Pattern:**
  The scoring mechanism in `BlackjackHand` uses a strategy pattern to calculate the score based on card values.



## Refactoring Techniques

Refactoring techniques applied during development:

- **Extract Method:**
  Large chunks of code were broken down into smaller, reusable methods to improve readability and maintainability.

- **Consolidate Conditional Expressions:**
  Complex conditional logic was simplified and consolidated to enhance code readability and reduce duplication.
  
- **Extract Class:**
  This technique involves extracting part of the functionality from an existing class and placing it into a separate class. It helps improve code structure, making it more modular and understandable.

