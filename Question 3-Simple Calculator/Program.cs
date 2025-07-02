using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3_Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int choice;

            
           
           
           
           
            
           
           
           
            do
            {
                
                    Console.WriteLine("Welcome to mutsa Calculator");
                    Console.WriteLine("Input a number");
                   number = int.Parse(Console.ReadLine());

                    Console.WriteLine();

                    Console.WriteLine("Now choose the following: ");
                    Console.WriteLine("1. Multiply");
                    Console.WriteLine("2.Addition");
                    Console.WriteLine("3.Subtraction");
                    Console.WriteLine("4.Division");
                    Console.WriteLine("5.Exit");
                    Console.WriteLine();
                    Console.WriteLine("Type your choice down below");
                    choice = int.Parse(Console.ReadLine());



                    if (choice == 1)
                    {

                    int MultNum;
                    int FinMultNum;

                    Console.WriteLine("Enter the value you wish to multply against your Input: ");
                        MultNum = int.Parse(Console.ReadLine());

                        Console.Write("Results of multiplication: ");
                        FinMultNum = MultNum * number;
                        Console.Write(FinMultNum);

                        Console.WriteLine();
                    

                }

                    else if (choice == 2)

                    {
                    int Addnum;
                    int FinAddnum;
                    Console.WriteLine("Enter the value you wish to add towards your Input: ");
                        Addnum = int.Parse(Console.ReadLine());

                    FinAddnum = number + Addnum;
                    Console.Write("Results of Addition: ");
                       
                        Console.WriteLine(FinAddnum);
                        Console.WriteLine();
                   
                }
                    else if (choice == 3)

                    {
                    int SubNum;
                    int FinSubNum;

                    Console.WriteLine("Enter the value you wish to subtract towards your Input: ");
                        SubNum = int.Parse(Console.ReadLine());

                        Console.Write("Results of Subtraction: ");
                        FinSubNum = number - SubNum ;
                        Console.Write(FinSubNum);
                        Console.WriteLine();
                    

                }

                    else if (choice == 4)

                    {
                    int DivNum;
                    int FinDivNum;
                    Console.WriteLine("Enter the value you wish to Divide against your Input: ");
                        DivNum = int.Parse(Console.ReadLine());

                        Console.Write("Results of Division: ");
                        FinDivNum = number / DivNum;
                        Console.Write(FinDivNum);
                        Console.WriteLine();
                   

                }
                    else if (choice == 5)

                    {
                        Console.WriteLine("You have successfully exited the application: ");
                        
                    
                  
                    }
                else
                {


                    Console.WriteLine("Invalid output");
                }











                
            }
            while (choice != 5);
        }
    }
}
