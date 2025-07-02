using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C__Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> tasks = new Dictionary<int,string>();/* Now this is intiallising a collection called task remember mutsa that a 
                                                                         * the dictionary collection when being used offer the benfit of having a key or inserting a key number inshort i need this so that my rows are numbers and have a unique ID LOOKING LIKE THIS"1.nEW TASK"*/
            int choice;


            do
            {                                                                                       //Will print out the following strings//
                Console.WriteLine("\nWelcome to To-Do List Manager");                              //I'll be using a do...while loop here. //
                Console.WriteLine("1. Create task");                                               // It's important to understand that if you use only a while loop (without "do"),//
                Console.WriteLine("2. View tasks");                                               //the condition is checked *before* any code inside the loop runs.//
                Console.WriteLine("3. Update task");                                              // In contrast, the do...while loop ensures that the code inside the loop executes//
                Console.WriteLine("4. Delete task");                                              //at least once before the condition is checked.//
                Console.WriteLine("5. Exit");                                                      // For example, the condition here is (choice != 5). This means://
                Console.Write("Enter your choice: ");                                              // - As long as the user's input is NOT 5, the menu will keep showing.
                                                                                                   // - If the user enters 5, then 5 != 5 is false, so the loop ends, and the program exits.//
                                                                                                   /* In short, let me explain — remember this is a loop. 
                                                                                                   * The loop continues running until the condition becomes false.
                                                                                                   *The condition here is: "choice is not equal to 5".
                                                                                                   *When the user enters a value from 1 to 4, those values are **not** equal to 5.
                                                                                                   *Therefore, the condition is true, and the loop continues.
                                                                                                   *However, if the user inputs 5, then 5 is equal to 5.
                                                                                                   *That makes the condition false, so the loop stops running.
                                                                                                   *Remember: the condition means "whatever is input is NOT equal to 5".
                                                                                                   *That’s why entering 5 breaks the loop and exits the program.S*/




                                                                       //The readline will ask for user input whilst checking for whether input is a string//
                if (!int.TryParse(Console.ReadLine(), out choice))     // The difference between TryParse and Parse is that both are used to convert a string to an integer.//
                {                                                      // The key difference is that **TryParse** checks first if the value can be converted to an integer.//
                    Console.WriteLine("Invalid input.");               // It returns a **true or false** — true if the string **can** be converted to an integer, and false if it **cannot**.//
                    continue;                                          // **Parse**, on the other hand, will throw an error if the value is not a valid integer.//
                }                                                      // In this scenario, we use **TryParse** with an exclamation mark (!) in the `if` statement.//
                                                                       // The exclamationmark means "NOT", so the condition becomes: "If the input is **not** a valid integer"//
                                                                       //This makes the program print an error message if the user enters something that isn't a number.//
                
                  
                  
                

                switch (choice)                                                //
                {
                    case 1:
                        AddTask(tasks);

                        break;
                    case 2:
                        ViewTasks(tasks);
                        break;
                    case 3:
                        UpdateTask(tasks);
                        break;
                    case 4:
                        DeleteTask(tasks);
                        break;
                    case 5:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 5);
        }

        // Adds a new task to the dictionary//
        static void AddTask(Dictionary<int, string> tasks)                            
        {
            string j;// Variable to store the new task description//

            // Prompt user to enter a task//
            Console.Write("Enter a new task: ");
            j = Console.ReadLine();// Read user input//


            // Generate a new task ID by adding 1 to the current count of tasks//
            int i = tasks.Count + 1;

            // Add the new task to the dictionary with the new ID//
            tasks.Add(i, j);

            // Confirm the task was added and pause the screen//
            Console.WriteLine("Added task successfully. Press any key to continue...");

            Console.ReadKey(); // Wait for user input before continuing//
        }

        // Method to display all tasks in the dictionary//
        static void ViewTasks(Dictionary<int, string> tasks)
        {
            // Iterate through each key-value pair in the dictionary//
            foreach (var AllTask in tasks) 
            Console.WriteLine($"{AllTask.Key}: {AllTask.Value}");
        }

        // Method to update a specific task in the dictionary//
        static void UpdateTask(Dictionary<int, string> tasks)
        {
            Console.WriteLine($"Type down below the ID number of task that you want to update: ");
            int UpTask;
            UpTask = int.Parse(Console.ReadLine()); // Read user input and convert to integer//


            // Check if the task ID exists in the dictionary//
            if (tasks.TryGetValue(UpTask, out string prevTask))

            {
                // Prompt user to enter the updated task description//
                Console.WriteLine("Type down below the updated task:");
                string updateChangeTask = Console.ReadLine();


                // Update the task with the new value//
                tasks[UpTask] = updateChangeTask;
                Console.WriteLine($"Task updated successfully. New task: {updateChangeTask}");

            }
            else
            {
                // If task ID doesn't exist, show error message//
                Console.WriteLine("ID entered is invalid");


            }
           
        }
        // Method to delete a task from the dictionary//
        static void DeleteTask(Dictionary<int, string> tasks)
        {
            int DelTask;

            // Prompt user to enter the ID of the task to be deleted//
            Console.WriteLine($"Enter the ID number of task you wish to delete down below:");

            DelTask = int.Parse(Console.ReadLine());

            // Check if the task ID exists before trying to delete it//
            if (tasks.TryGetValue(DelTask , out string RemoveOldTask))
            {

                tasks.Remove(DelTask);// Remove the task from the dictionary//
                Console.WriteLine("Task removed successfully");

            }
            else
            {


                Console.WriteLine("Invalid input entered");  // Show error if the task ID is not found//
            }
        }
    }
}

