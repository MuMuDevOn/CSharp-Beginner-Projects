using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_9_Dice_Roller_Simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Dice Roller Simulator!");
            Console.WriteLine("Press 'r' to roll the dice or 'q' to quit.");

            


            


            string input = "R";
            while (input == "R")

            {

                Random DiceRoll = new Random();
                int FirstDiceRoll = DiceRoll.Next(1, 7);
                int SecondDiceRoll = DiceRoll.Next(1, 7);



                Console.WriteLine("Press any key on the board for the game to begin");
                Console.ReadKey();

                Console.WriteLine("The dice is in the process of rolling");
        System.Threading.Thread.Sleep(5000); // Simulate rolling time
          
                Console.WriteLine();
                Console.WriteLine("The Dice has completed it's roll");

                System.Threading.Thread.Sleep(2000); // Simulate rolling time
                Console.WriteLine("Press any key to see the result of the roll");
                Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine($"The first dice rolled a {FirstDiceRoll}");
                Console.WriteLine($"The second dice rolled a {SecondDiceRoll}");
                int Steps = FirstDiceRoll + SecondDiceRoll;


                Console.WriteLine();
                Console.WriteLine($"Therefore the dice has move on the board {Steps} steps");

                System.Threading.Thread.Sleep(4000);

                try
                {
                    Console.WriteLine("Type 'r' to roll again or 'q' to quit.Down below");
                    input = Console.ReadLine().ToUpper();

                    if (input == "Q")

                    {

                        Console.WriteLine("==Thank you for playing the Dice Roller Simulator!==");

                    }

                    else if (input == "R")
                    {

                        Console.WriteLine("==Welcome back to the Dice Roller Simulator!==");

                    }

                    else{ 
                    
                    Console.WriteLine("Invalid input. Please enter 'r' to roll again or 'q' to quit.");
                        input = "R";

                    }
                }
                 catch (Exception ex)
                {
                    Console.WriteLine("ERROR MESSAGE!!: " + ex.Message);
                }

                


            }


           


        }
    }
}
