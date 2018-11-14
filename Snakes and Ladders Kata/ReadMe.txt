The program is a standard C# Console Application, so can be run as such.

The program runs in main where the main game logic takes place. However data for the token and the dice roll mechanism are held in seperate classes. 

An Interface is used to implement a basic Strategy Pattern for IMoveable inherited by Counter. 

An Observer Pattern could be added to check on further tokens as the game is expanded, but was a little too much time to code for the scope of this solution.