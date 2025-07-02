using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Question_7_Student_Grade_Tracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int choice = 0;
            string gradeClassify = "";
            ArrayList studentsDe = new ArrayList();

            do
            {

                Console.WriteLine("Choose the following options");
                Console.WriteLine("1.Enter student Details");
                Console.WriteLine("2.View student detail");
                Console.WriteLine("3.Exit");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the student name");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter the student grade");
                        int grade = int.Parse(Console.ReadLine());



                        if (grade >= 0 && grade <= 39)
                        {




                            string Fail = "F";

                            gradeClassify = Fail;






                        }


                        else if (grade >= 40 && grade <= 49)
                        {




                            string ModerateFail = "E";
                            gradeClassify = ModerateFail;





                        }

                        else if (grade >= 50 && grade <= 59)
                        {




                            string Pass = "D";
                            gradeClassify = Pass;




                        }

                        else if (grade >= 60 && grade <= 69)
                        {




                            string ModeratePass = "E";
                            gradeClassify = ModeratePass;





                        }


                        else if (grade >= 70 && grade <= 79)
                        {




                            string ExceptionalPass = "B";
                            gradeClassify = ExceptionalPass;





                        }

                        else if (grade >= 80 && grade <= 100)
                        {




                            string Distiction = "A";
                            gradeClassify = Distiction;




                        }





                



                Student studentDetails = new Student(name, grade, gradeClassify);




                studentsDe.Add(studentDetails);

                break;


            

                    case 2:

                        foreach(var StudDetails in studentsDe)
                        {

                            Console.WriteLine(StudDetails);


                        }


                        break;


                    case 3:

                        Console.WriteLine("You have successfully exited");


                        break;

                    

                    default:

                        Console.WriteLine("Invalid input");
                        break;

                }
                }

            while (choice != 3);


        }


        }


    
    class Student
    {
        string name;

        int grade;

        string gradeClassify;


        public Student(string name, int grade, string gradeClassify)
        {

            this.name = name;
            this.grade = grade;
            this.gradeClassify = gradeClassify;

        }
        public override string ToString()
        {
            return $"Name: {name}, Grade: {grade}, Classification: {gradeClassify}";
        }




    }
}
