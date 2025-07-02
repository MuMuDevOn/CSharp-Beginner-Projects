using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Question_6_Basic_ATM_Simulation
{
    internal class Program
    {
        static void Main(string[] args)


        {


            
            double CurrentAmount = 0;



            int choice = 0;
            do
            {
                Console.WriteLine($"Choose your following choices:");
                Console.WriteLine("1. Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdrawls");
                Console.WriteLine("4.Exit");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:


                        Balance(CurrentAmount);
                        break;
                    case 2:
                        CurrentAmount = Deposit(CurrentAmount);
                        break;

                    case 3:

                        CurrentAmount = WidthDraw(CurrentAmount);
                        break;
                    case 4:

                        Console.WriteLine("You have exited successfully");

                        break;

                    default:
                        Console.WriteLine("Invalid Input");

                        break;
                }


            }
            while (choice != 4);



        }


static double Balance(double CurrentAmount )
                {





            Console.WriteLine(CurrentAmount);
                return CurrentAmount;
                   
            


                }

                static double Deposit(double CurrentAmount)
                {

                    double AddNum;
                    

                    Console.Write("Enter namount you want to withdraw to add: ");
                    AddNum = Convert.ToDouble(Console.ReadLine());
                    double FinAddNum = CurrentAmount + AddNum;
                    Console.WriteLine($"You have successfully added in your account:  R{AddNum}");
                    CurrentAmount = FinAddNum;
            return CurrentAmount;



        }


                static double WidthDraw(double CurrentAmount)
                {

                    double MinNum;
                    

                    Console.Write("Enter amount you want to withdraw to add: ");
                    MinNum = Convert.ToDouble(Console.ReadLine());
                   double FinMinNum = CurrentAmount - MinNum;
                    CurrentAmount = FinMinNum;
                    Console.WriteLine($"The result is: {FinMinNum}");
            return CurrentAmount;


        }


         }
    }

    
