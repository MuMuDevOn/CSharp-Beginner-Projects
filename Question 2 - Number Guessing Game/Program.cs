using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2___Number_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {




            int InputValue = -1;

            
            

           

            int min = 0;
            int max = 100;
            Random gameValue = new Random();
            int randomValue = gameValue.Next(min,max);
            bool playAgain = true;
            int guesses = 0;

            string Response;

           

            

            while (playAgain)
            {

                Console.WriteLine("Welcome to the number guessing game: To proceed press enter ");
                Console.ReadKey();

                

                Console.ReadKey();
                Console.WriteLine();


              

                while (InputValue != randomValue)
                {

                    Console.WriteLine("Enter the value between the range of 0 to 100 down below: ");
                    InputValue = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("........Give us a moment, we are generating random values.........");
                    Console.WriteLine("Result Ready down below, tap on any key on the key to proceed ");

                    Console.ReadKey();
                    Console.WriteLine();

                    Console.WriteLine($"User input ({InputValue})  : ComputerInput ({randomValue}) ");

                    Console.WriteLine("Press Enter to proceed");
                    Console.ReadKey();
                    Console.WriteLine();
                    Console.ReadKey();


                    if (InputValue > randomValue)
                    {

                        Console.WriteLine("The value you entered is larger than the computer amount");
                        Console.WriteLine("Failed this round, try again: Press enter to proceed");
                        Console.ReadKey();
                        Console.WriteLine();
                        Console.WriteLine("Press enter to proceed");
                        Console.WriteLine();
                       

                        Console.WriteLine("Would you Like to play Again: Y/N");
                        Console.WriteLine($"Enter your answer: {Response = Console.ReadLine()}");
                        Response = Response.ToUpper();

                        if (Response == "Y")
                        {

                            playAgain = true;
                        }

                        else if (Response == "N")
                        {
                            Console.WriteLine("Thank you for play our game, please do leave a review");
                            playAgain = false;
                        }


                        else
                        {

                            Console.WriteLine("You have entered an invalid value");
                        }

                        break;

                    }
                    else if (InputValue < randomValue)
                    {
                        Console.WriteLine("The value you entered is smaller than the computer amount");
                        Console.WriteLine("Failed this round, try again");
                        Console.ReadKey();
                        Console.WriteLine();
                        Console.WriteLine("Press enter to proceed");
                        Console.WriteLine();
                        
                        Console.WriteLine("Would you Like to play Again: Y/N");
                        Console.WriteLine($"Enter your answer: {Response = Console.ReadLine()}");
                        Response = Response.ToUpper();

                        if (Response == "Y")
                        {

                            playAgain = true;
                        }

                        else if (Response == "N")
                        {
                            Console.WriteLine("Thank you for play our game, please do leave a review");
                            playAgain = false;
                        }


                        else
                        {

                            Console.WriteLine("You have entered an invalid value");
                        }

                        break;
                    }

                    else
                    {


                        Console.WriteLine("You entered the right amount");
                        Console.WriteLine("Congratulations for winning this round");
                        playAgain = false;
                        break;


                    }


                   
                   
                 


                }
                guesses++;

            }


           


            
            

            

         
            
        }
    }
}
