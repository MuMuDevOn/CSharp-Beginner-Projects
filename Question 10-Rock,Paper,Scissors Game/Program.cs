using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_10_Rock_Paper_Scissors_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("Welcome to the MumUCorp Rock,Paper,Scissors Game!");
            //Run logic
            PlayGame();


        }

        // Method to run the game
        static void PlayGame()
        {
            // Array of possible choices for the game
            string[] ModeArray = new string[] { "ROCK", "PAPER", "SCISSORS" };

            // Game logic will be implemented here
            Console.WriteLine("Game is starting...");
            // Add game logic here

           

            // Loop control variable for playing the game again
            string Valid = "Z";

            // Outer loop for playing multiple sessions
            while (Valid == "Z")

            { 
                // Inner loop for playing 3 rounds per session
                for (int i = 0; i < 3; i++)
                {
                    // Create a new Random object to generate computer choices
                    Random Mode = new Random();
                    string FirstMode = ModeArray[Mode.Next(ModeArray.Length)];

                    Console.WriteLine("Choose your mode: Rock, Paper, or Scissors?");
                    string UserMode = Console.ReadLine();
                    UserMode = UserMode.ToUpper();// Convert user input to uppercase for consistency

                    Console.WriteLine($"The computer has chosen: { FirstMode} vs YourInput:  {UserMode} ");
                    // Handle tie
                    if (UserMode == FirstMode)
                    {


                        Console.WriteLine("It's a tie! You both chose " + UserMode + ".");



                    }
                    // Player wins conditions
                    else if (UserMode == "ROCK" & FirstMode == "SCISSORS")
                    {

                        Console.WriteLine("You win this round! Rock beats Scissors.");
                        Console.WriteLine("The computer won lost this round");
                    }

                    else if (UserMode == "PAPER" & FirstMode == "SCISSORS")
                    {

                        Console.WriteLine("You lose this round! Rock beats Scissors.");
                        Console.WriteLine("The computer won this round");

                    }

                    else if (UserMode == "PAPER" & FirstMode == "ROCK")
                    {

                        Console.WriteLine("You win this round! Rock beats Scissors.");
                        Console.WriteLine("The computer lost this round");
                    }





                    // Player loses conditions
                    else if (FirstMode == "ROCK" & UserMode == "SCISSORS")
                    {

                        Console.WriteLine("You lose this round! Rock beats Scissors.");
                        Console.WriteLine("The computer won this round");
                    }

                    else if (FirstMode == "PAPER" & UserMode == "SCISSORS")
                    {

                        Console.WriteLine("You win this round! Rock beats Scissors.");
                        Console.WriteLine("The computer lost this round");

                    }

                    else if (FirstMode == "PAPER" & UserMode == "ROCK")
                    {

                        Console.WriteLine("You lose this round! Rock beats Scissors.");
                        Console.WriteLine("The computer won this round");
                    }

                    // Handle invalid input
                    else
                    {


                        Console.WriteLine("Invalid input. Please choose Rock, Paper, or Scissors.");
                        continue;// Skip rest of loop and re-ask
                    }
                   
                   
                       

                    }
                Console.WriteLine("==This session is over==");

                // Ask user if they want to play again
                Console.WriteLine("Do you want to play again? (Y/N)");
                string Stay = Console.ReadLine().ToUpper();
                if (Stay == "Y")
                {
                    Console.WriteLine("Welcome back to the game");
                    
                    Valid = "Z";// Stay in the game

                }

                else if (Stay == "N")
                {
                    Console.WriteLine("Thank you for playing! Goodbye!");
                    
                    Valid = "G";// Leave the game

                }
                else
                {

                    Console.WriteLine("Invalid input. Please enter Y or N.");
                    Valid = "Z";// Re-ask play again
                    continue;// Skip rest of loop and re-ask
                }
            }

        }
    }
}
