# Word Scramble

Word Scramble is a simple C# Windows Forms game where the player has to guess the correct word from scrambled letters.

## Preview

![Word Scramble game](https://github.com/user-attachments/assets/6ececdae-12bf-41f4-8c2c-86b70db69c8e)

## Features

* Random scrambled words
* Score system
* Hint system
* Guessed words counter
* 45-second timer for each word
* Failed attempts list
* Dark mode / light mode option

## How the Game Works

The game chooses a random word from `words.txt` and scrambles its letters.
The player has to type the correct word and press **Check**.

## Scoring System

* Correct answer without hints: +15 points
* Correct answer with 1 hint: +10 points
* Correct answer with 2 hints: +5 points
* Wrong answer: 0 points

## Hint System

The player can use up to 2 hints for each word.

* First hint shows the first letter
* Second hint shows the second letter
* Each hint reduces the reward for the current word by 5 points; it does not subtract from the accumulated score

## Timer

Each word has a 45-second timer.
If the timer reaches 0, the game shows the correct word and moves to a new word.

## Guessed Words Counter

The **Guessed words** counter shows the total number of correct answers in the current game. It does not reset after a wrong answer, a skipped word, or a timeout.

## Dark Mode

The player can switch between light mode and dark mode using the **Dark Mode** button.

## Technologies Used

* C#
* Windows Forms
* .NET
