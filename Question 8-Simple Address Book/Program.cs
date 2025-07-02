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
                Console.WriteLine("4.Exit");
                Console.WriteLine("Type down infomation ");

                bool valid = int.TryParse(Console.ReadLine(), out choice);

                if (!valid)
                {

                    Console.WriteLine("You have entered an invalid input");



                }

                switch (choice)
                {

                    case 1:

                        addressbook.InsertInput();
                        break;
                    case 2:
                        addressbook.Display(AddressInput,path);
                        break;
                    case 3:
                        addressbook.UpdateEmail(AddressInput);
                        break;
                   
                    default:

                        Console.WriteLine("You have entered invalid input");
                        break;













                }










            }
            while (choice != 3);











        }
    }
    class Addressbook
    {

        private string Ename;
        private long Ephone;
        private string Email;

        public string ename

        {
            get { return Ename; }
            set { Ename = value; }
        }

        public long ephone
        {
            get { return Ephone; }
            set { Ephone = value; }

        }


        public string email
        {
            get { return Email; }
            set { Email = value; }


        }

        public Addressbook()


        {




        }


        public static void MiniDisplay(string ename, string email)
        {

            Console.WriteLine($"Name:{ename}, Email: {email}");


        }





        public void InsertInput()
        {

          

            Dictionary<long, string> AddressInput = new Dictionary<long, string>();





            Console.WriteLine("Insert Info down below");

            try
            {
                Console.WriteLine("Type your name");
                ename = Console.ReadLine();
                Console.WriteLine("Type your phone number");
                ephone = long.Parse(Console.ReadLine());
                Console.WriteLine("Type down your email address");
                email = Console.ReadLine();


            }
            catch (Exception ex)
            {

                Console.WriteLine($"The input you have entered is in an invalid input: {ex.Message}");
            }

            AddressInput.Add(ephone, $"Name:{ename}, Email: {email}");


            Console.WriteLine("==USER EMAIL ADDRESS SUCCESSFULL ADDED==");




        }
        public void Display(Dictionary<long, string> AddressInput,string path)

        {
            int option = 0;
            Console.WriteLine("Welcome to display menu");

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

                        
                        foreach (long Tkey in AddressInput.Keys)
                        {
                            Console.WriteLine("Enter your phone number to view list");
                            long Tkeys = long.Parse(Console.ReadLine());
                            if (ephone == Tkey )
                            {
                               
                                Console.WriteLine($"User found:  { ename} : {email }");
                            }
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

            
           
            if (File.Exists(path))
            {


                string Content = $"Name:{ename}, Email: {email} , Phone Number: {ephone}\n";
                File.AppendAllText(path, Content);


            }




        }


        public void UpdateEmail(Dictionary<long, string> AddressInput)
        {

            
            Console.WriteLine("Enter your phone number");
            long Keys = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter the information you want to update into");
            string Up = Console.ReadLine();


            foreach (long TKeys in AddressInput.Keys)
            {
                if (ephone == Keys)
                {

                    AddressInput[ephone] = Up;
                    Console.WriteLine("==You have successfully updated information==");


                }
            }

           



        }
    }
}















