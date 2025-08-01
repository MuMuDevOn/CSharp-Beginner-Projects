using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Question_8_Simple_Address_Book
{
    internal class Program
    {
        static void Main(string[] args)
        {



            string path = "C:\\Users\\mutsa\\OneDrive\\Documents\\C# beginning\\Question 8-Simple Address Book\\AddressBook.txt";

            Addressbook addressbook = new Addressbook();
            Dictionary<long, string> AddressInput = new Dictionary<long, string>();
            
            int choice = 0;
            Console.WriteLine("Welcome to the mutsa address book");



            do
            {
                Console.WriteLine("1.Insert address info");
                Console.WriteLine("2.Display information");
                Console.WriteLine("3.Update information");
                Console.WriteLine("4.Remove information");
                Console.WriteLine("5.Exit");
                Console.WriteLine("Type down infomation ");

                bool valid = int.TryParse(Console.ReadLine(), out choice);

                if (!valid)
                {

                    Console.WriteLine("You have entered an invalid input");



                }

                switch (choice)
                {

                    case 1:

                        addressbook.InsertInput(AddressInput);
                        break;
                    case 2:
                        addressbook.Display(AddressInput);
                        break;
                    case 3:
                        addressbook.UpdateEmail(AddressInput);
                        break;
                    case 4:
                        addressbook.RemoveEmail(AddressInput);
                        break;
                    case 5:
                        Console.WriteLine("==You have successfully exited the program");
                        break;

                    default:

                        Console.WriteLine("You have entered invalid input");
                        break;













                }










            }
            while (choice != 5);











        }
    }
    class Addressbook
    {

       
        Dictionary<long, string> AddressInput = new Dictionary<long, string>();

       

        public Addressbook()


        {




        }


        public static void MiniDisplay(string ename, string email)
        {

            Console.WriteLine($"Name:{ename}, Email: {email}");


        }





        public void InsertInput(Dictionary<long, string> AddressInput)
        {

          
            
            





            Console.WriteLine("Insert Info down below");

            try
            {
                Console.WriteLine("Type your name");
                string Ename = Console.ReadLine();
                Console.WriteLine("Type your phone number");
                long Ephone = long.Parse(Console.ReadLine());
                Console.WriteLine("Type down your email address");

                string Email = Console.ReadLine();
                AddressInput.Add(Ephone, $"Name:{Ename}, Email: {Email}");


                Console.WriteLine("==USER EMAIL ADDRESS SUCCESSFULL ADDED==");


            }
            catch (Exception ex)
            {

                Console.WriteLine($"The input you have entered is in an invalid input: {ex.Message}");
            }

           



        }
        public void Display(Dictionary<long, string> AddressInput)

        {
            
            Console.WriteLine("Welcome to display menu");
            int option = 0;
            do
            {
                Console.WriteLine("Choose the following option");
                Console.WriteLine("1.View All list");
                Console.WriteLine("2.View specific email");
                Console.WriteLine("3.Exit");
                Console.WriteLine("Enter option down below");
               
                bool valid = int.TryParse(Console.ReadLine(), out  option);



                switch (option)
                {


                    case 1:
                        foreach (var DisEmail in AddressInput)
                        {

                            Console.WriteLine($"{DisEmail}\n");


                        }
                        break;
                    case 2:
                            Console.WriteLine("Enter your phone number to view list");
                            long Tkeys = long.Parse(Console.ReadLine());

                            if (AddressInput.ContainsKey(Tkeys))
                            {
                            Console.WriteLine($"Phone: {Tkeys}, Info: {AddressInput[Tkeys]}");
                        }
                        
                        break;
                    case 3:


                        Console.WriteLine("==YOU HAVE SUCCESSFULLY EXITED THE LOOP ==");
                        

                        break;
                    default:
                        Console.WriteLine("You have entered invalid input");
                        


                        break;




                }

            }
            while (option != 3);

            
           
     




        }


        public void UpdateEmail(Dictionary<long, string> AddressInput)
        {

            
            Console.WriteLine("Enter your phone number");
            string Ename;
            string Email;

            if (long.TryParse(Console.ReadLine(), out long Keys))
            {
                if (AddressInput.ContainsKey(Keys))
                {
                    Console.WriteLine("Enter the information you want to update into");
                    Console.WriteLine();
                    Console.WriteLine("Enter the update name you want to update into");
                    Ename = Console.ReadLine();
                    Console.WriteLine("Enter the update Email you want to update into");
                    Email = Console.ReadLine();
                    string Up = $"Name: {Ename}, Email: {Email}";
                    AddressInput[Keys] = Up;
                    Console.WriteLine("==You have successfully updated information==");
                }
                else
                {
                    Console.WriteLine("Phone number not found in address book.");
                }
            }
            else
            {
                Console.WriteLine("Invalid phone number input.");
            }
            

           



        }

        public void RemoveEmail(Dictionary<long, string> AddressInput) 
        {

            Console.WriteLine("Enter your phone number:");
    
    if (long.TryParse(Console.ReadLine(), out long eKey))
    {
        if (AddressInput.ContainsKey(eKey))
        {
            AddressInput.Remove(eKey);
            Console.WriteLine("Email removed successfully.");
        }
        else
        {
            Console.WriteLine("Phone number not found in address book.");
        }
    }
    else
    {
        Console.WriteLine("Invalid phone number input.");
    }






        }
    }
}















