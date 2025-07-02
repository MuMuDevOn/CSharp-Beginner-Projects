using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Question_4_Unit_Convertor
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double Lend;
            Console.WriteLine("Enter the value you want to convert: ");
            Lend = double.Parse(Console.ReadLine());

            Console.WriteLine("Choose the sub- topic");
            Console.WriteLine("1.Lenght conversions");
            Console.WriteLine("2.Weight conversion");
            Console.WriteLine("3.Volume conversion");

            int choice = int.Parse(Console.ReadLine());


            switch (choice)
            {
                case 1:

                    {


                        length(Lend);
                        break;
                    }

                case 2:

                    {
                        Weight(Lend);
                        break;



                    }


                case 3:
                    {


                        Volume(Lend);
                        break;

                    }

                default:
                    {

                        Console.WriteLine("Invalid input");
                        break;
                    }







            }








        }



        static void length(double Lend)
        {




            Console.WriteLine("Choose the unit type of the value you enter");
            Console.WriteLine("1.Millimeters");
            Console.WriteLine("2.Centimeter");
            Console.WriteLine("3.meter");
            Console.WriteLine("4.Kilometer");
            Console.WriteLine("5.Inches");
            int Type = int.Parse(Console.ReadLine());

            if (Type == 1)
            {
                Console.WriteLine("Choose type of conversion");
                Console.WriteLine("1.Millimeters to Centimers");
                Console.WriteLine("2.Millimeters to Meters");
                Console.WriteLine("3.Millimeters to Kilometers");
                Console.WriteLine("4.Millimeters to Inches");
                Console.WriteLine("5.Exit");

                int MilliCov = int.Parse(Console.ReadLine());

                switch (MilliCov)
                {
                    case 1:

                        {
                            double CenLend = Lend / 10;
                            Console.WriteLine(CenLend);



                            break;
                        }
                    case 2:

                        {
                            double MeLend = Lend / 1000;
                            Console.WriteLine(MeLend);

                            break;
                        }


                    case 3:
                        {

                            double MeLend = Lend / 1000000;
                            Console.WriteLine(MeLend);

                            break;

                        }

                    case 4:
                        {

                            double InchLend = Lend * 0.0393701;
                            Console.WriteLine(InchLend);


                            break;
                        }

                    case 5:
                        {

                            Console.WriteLine("You have exited loop successfully");

                            break;
                        }

                    default:
                        {

                            Console.WriteLine("Invalid Option");
                            break;
                        }
                }



            }
            if (Type == 2)
            {
                Console.WriteLine("Choose type of conversion");
                Console.WriteLine("1.Centimeters to Millimeters");
                Console.WriteLine("2.Centimeters to Meters");
                Console.WriteLine("3.Centimeters to Kilometers");
                Console.WriteLine("4.Centimeters to Inches");
                Console.WriteLine("5.Exit");
                double CentiCov = double.Parse(Console.ReadLine());

                switch (CentiCov)
                {
                    case 1:

                        {
                            double MillCend = Lend * 10;
                            Console.WriteLine(MillCend);

                            break;
                        }
                    case 2:

                        {
                            double MeLend = Lend / 100;
                            Console.WriteLine(MeLend);

                            break;
                        }


                    case 3:
                        {

                            double KMeLend = Lend / 100000;
                            Console.WriteLine(KMeLend);

                            break;

                        }

                    case 4:
                        {

                            double InchLend = Lend * 0.393701;
                            Console.WriteLine(InchLend);

                            break;
                        }

                    case 5:
                        {

                            Console.WriteLine("You have exited loop successfully");

                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Invalid Option");

                            break;
                        }


                }

            }

            if (Type == 3)
            {
                Console.WriteLine("Choose type of conversion");
                Console.WriteLine("1.Meters to Millimeters");
                Console.WriteLine("2.Meters to Centimeters");
                Console.WriteLine("3.Meters to Kilometers");
                Console.WriteLine("4.Meters to Inches");
                Console.WriteLine("5.Exit");

                double MentiCov = double.Parse(Console.ReadLine());

                switch (MentiCov)
                {

                    case 1:

                        {
                            double MillCend = Lend * 1000;
                            Console.WriteLine(MillCend);

                            break;
                        }
                    case 2:

                        {
                            double CenLend = Lend * 100;
                            Console.WriteLine(CenLend);

                            break;
                        }


                    case 3:
                        {

                            double KMeLend = Lend / 1000;
                            Console.WriteLine(KMeLend);

                            break;

                        }

                    case 4:
                        {

                            double InchLend = Lend * 39.3701;
                            Console.WriteLine(InchLend);

                            break;
                        }

                    case 5:
                        {

                            Console.WriteLine("You have exited loop successfully");

                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Invalid Option");
                            break;

                        }


                }
            }


            if (Type == 4)
            {
                Console.WriteLine("Choose type of conversion");
                Console.WriteLine("1.Kilometers to Millimeters");
                Console.WriteLine("2.Kilometers to Centimeters");
                Console.WriteLine("3.Kilometers to Meters");
                Console.WriteLine("4.Kilometers to Inches");
                Console.WriteLine("5.Exit");

                double KCentiCov = double.Parse(Console.ReadLine());

                switch (KCentiCov)
                {
                    case 1:

                        {
                            double MillCend = Lend * 1000000;
                            Console.WriteLine(MillCend);

                            break;
                        }
                    case 2:

                        {
                            double CenLend = Lend * 100000;
                            Console.WriteLine(CenLend);
                            break;
                        }


                    case 3:
                        {

                            double MeLend = Lend * 1000;
                            Console.WriteLine(MeLend);

                            break;

                        }

                    case 4:
                        {

                            double InchLend = Lend * 39370.1;
                            Console.WriteLine(InchLend);

                            break;
                        }

                    case 5:
                        {

                            Console.WriteLine("You have exited loop successfully");

                            break;
                        }

                    default:

                        {
                            Console.WriteLine("Invalid Option");
                            break;
                        }


                }
            }





            if (Type == 5)
            {
                Console.WriteLine("Choose type of conversion");
                Console.WriteLine("1.Inches to Millimeters");
                Console.WriteLine("2.Inches to Centimeters");
                Console.WriteLine("3.Inches to Meters");
                Console.WriteLine("4.Inches to Kilometers");
                Console.WriteLine("5.Exit");

                double InchesCov = double.Parse(Console.ReadLine());

                switch (InchesCov)
                {
                    case 1:

                        {
                            double MillCend = Lend * 25.4;
                            Console.WriteLine(MillCend);

                            break;
                        }
                    case 2:

                        {
                            double CenLend = Lend * 2.54;
                            Console.WriteLine(CenLend);

                            break;
                        }


                    case 3:
                        {

                            double MeLend = Lend * 0.0254;
                            Console.WriteLine(MeLend);

                            break;

                        }

                    case 4:
                        {

                            double KMeLend = Lend * 0.0000254;
                            Console.WriteLine(KMeLend);

                            break;
                        }

                    case 5:
                        {

                            Console.WriteLine("You have exited loop successfully");


                            break;
                        }

                    default:

                        {
                            Console.WriteLine("Invalid Option");
                            break;
                        }


                }






            }
        }


                    
                
            
        







        static void Weight(double Lend)
        {




            Console.WriteLine("Choose the unit type of the value you enter");
            Console.WriteLine("1.Milligrams");
            Console.WriteLine("2.gram");
            Console.WriteLine("3.Kilogram");
            
            int Type = int.Parse(Console.ReadLine());

            if (Type == 1)
            {
                Console.WriteLine("Choose type of conversion");
                Console.WriteLine("1.Milligrams to gram");
                Console.WriteLine("2.Milligrams to Kilogram");
                Console.WriteLine("3.Exit");

                int MilliCov = int.Parse(Console.ReadLine());

                switch (MilliCov)
                {
                    case 1:

                        {
                            double gramLend = Lend / 1000;
                            Console.WriteLine(gramLend);

                            break;
                        }
                    case 2:

                        {
                            double kiloLend = Lend / 1000000;
                            Console.WriteLine(kiloLend);


                            break;
                        }


                    case 3:
                        {

                            Console.WriteLine("You have exited loop successfully");

                            break;
                        }

                    default:
                        {

                            Console.WriteLine("Invalid Option");
                            break;
                        }
                }

            }

            if (Type == 2)
            {
                Console.WriteLine("Choose type of conversion");
                Console.WriteLine("1.gram to.Milligrams");
                Console.WriteLine("2.gram to Kilogram");
                Console.WriteLine("3.Exit");

                int gramCov = int.Parse(Console.ReadLine());

                switch (gramCov)
                {
                    case 1:

                        {
                            double MilliLend = Lend * 1000;
                            Console.WriteLine(MilliLend);

                            break;
                        }
                    case 2:

                        {
                            double kiloLend = Lend / 1000;
                            Console.WriteLine(kiloLend);

                            break;
                        }


                    case 3:
                        {

                            Console.WriteLine("You have exited loop successfully");


                            break;
                        }

                    default:
                        {

                            Console.WriteLine("Invalid Option");

                            break;
                        }
                }

            }


            if (Type == 3)
            {
                Console.WriteLine("Choose type of conversion");
                Console.WriteLine("1.Kilogram to.Milligrams");
                Console.WriteLine("2.Kilogram to gram");
                Console.WriteLine("3.Exit");

                int KiloCov = int.Parse(Console.ReadLine());

                switch (KiloCov)
                {
                    case 1:

                        {
                            double MilliLend = Lend * 1000000;
                            Console.WriteLine(MilliLend);

                            break;
                        }
                    case 2:

                        {
                            double gramLend = Lend * 1000;
                            Console.WriteLine(gramLend);

                            break;
                        }


                    case 3:
                        {

                            Console.WriteLine("You have exited loop successfully");

                            break;
                        }

                    default:
                        {

                            Console.WriteLine("Invalid Option");
                            break;
                        }
                }

            }

        }






        static void Volume(double Lend)
        {




            Console.WriteLine("Choose the unit type of the value you enter");
            Console.WriteLine("1.Milliliter to liter");
            Console.WriteLine("2.Liter to milliliter");

            Console.WriteLine("To exit press 3");

            int Type = int.Parse(Console.ReadLine());

            if (Type == 1)
            {


                Console.WriteLine("1.Milliliter to Liter");


                double MilliLend = Lend / 1000;
                Console.WriteLine(MilliLend);


            }

            if (Type == 2)
            {

                Console.WriteLine("2.Liter to milliliter");


                double LiliLend = Lend * 1000;
                Console.WriteLine(LiliLend);








            }

            if (Type == 3)
            {


                Console.WriteLine("You have exited successfully");
            }

        }
    }




  }
    


