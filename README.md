# Word Scramble

Word Scramble is a simple C# Windows Forms game where the player has to guess the correct word from scrambled letters.

## Features

* Random scrambled words
* Score system
* Hint system
* Streak counter
* 30-second timer for each word
* Failed attempts list
* Dark mode / light mode option

## How the Game Works

The game chooses a random word from `words.txt` and scrambles its letters.
The player has to type the correct word and press **Check**.

## Scoring System

* Correct answer: +5 points
* Wrong answer: 0 points
* Hint used: 0 points

## Hint System

The player can use up to 2 hints for each word.

* First hint shows the first letter
* Second hint shows the second letter
* Each hint removes 5 points

## Timer

Each word has a 30-second timer.
If the timer reaches 0, the game shows the correct word and moves to a new word.

## Streak Counter

The streak counter shows how many correct answers the player gets in a row.

The streak resets when:

* The player guesses wrong
* The player skips the word
* The timer runs out

## Dark Mode

The player can switch between light mode and dark mode using the **Dark Mode** button.

## Technologies Used

* C#
* Windows Forms
* .NET
