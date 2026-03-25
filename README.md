# TwentyOne
C# TwentyOne Console Application
## TwentyOne Debugging Assignment

### What is this line of code doing (in TwentyOneRules class)?

return score > 21;

This line checks whether the player's score is greater than 21. If the score is above 21, the method returns true, meaning the player has busted in the game of Twenty-One. If the score is 21 or below, the method returns false and the player is still in the game.

### What is this block of code doing (in the Main method)? Step-by-step

1. The program begins execution in the Main method.
2. The program prints a welcome message to the console.
3. The player is asked to enter their name.
4. The name entered is stored in the variable playerName.
5. The program greets the player using the name they entered.
6. A boolean variable called playing is set to true so the game can start.
7. A while loop is used to keep the game running while the player wants to continue playing.
8. Inside the loop, the program simulates a round of the Twenty-One game.
9. The player is asked if they want to play another round.
10. If the player types anything other than "yes", the variable playing becomes false.
11. When playing becomes false, the loop stops and the program ends.
