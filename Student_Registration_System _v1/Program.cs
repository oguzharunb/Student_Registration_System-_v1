using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_Registration_System__v1
{
    class Program
    {

         /*
           github.com/oguztheaxl
         */

        static School school = new School();

        static void Main(string[] args)
        {
            Student_Registration_System__v1();
        }

        static void Student_Registration_System__v1()
        {

            Console.WriteLine("-----Welcome to Student Registration System-----");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();

            do
            {
                Menu();
            } while (true);


        }

        static void Menu()
        {

            Console.WriteLine();

            Console.WriteLine("to view the full student list (f)");
            Console.WriteLine("to register a student (r)");
            Console.WriteLine("to remove a student (d)");
            Console.WriteLine("to clear the console (c)");
            Console.WriteLine("to exit (x)");
            Console.WriteLine();
            Console.Write("What is your choice?: ");
            string choice = Console.ReadLine().ToUpper();

            switch (choice)
            {

                case "F":
                    WriteList(school.Students);
                    break;
                case "R":
                    RegisterStudent();
                    break;
                case "D":
                    RemoveStudent();
                    break;
                case "C":
                    Console.Clear();
                    break;
                case "X":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("invalid input , please try again");
                    break;
            }


        }

        static void RegisterStudent()
        {
            Console.WriteLine();

            string firstname = null;
            string lastname = null;
            int studnumber = 0;
            BRANCH branch = BRANCH.Null;

            do
            {
                try
                {
                    Console.Write("Please Enter Student Number: ");
                    studnumber = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("invalid entry, please try again");
                    Console.WriteLine();
                    continue;
                }
                break;
            } while (true);


            do
            {
                try
                {
                    Console.Write("Please Enter Student First Name: ");
                    firstname = Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("invalid entry, please try again");
                    Console.WriteLine();
                    continue;
                }
                break;
            } while (true);

            do
            {
                try
                {
                    Console.Write("Please Enter Student Last Name: ");
                    lastname = Console.ReadLine();

                }
                catch (Exception)
                {
                    Console.WriteLine("invalid entry, please try again");
                    Console.WriteLine();
                    continue;
                }
                break;
            } while (true);

            string branchTest;

            do
            {

                Console.WriteLine();
                Console.WriteLine("For Math (m)");
                Console.WriteLine("For Science (s)");
                Console.WriteLine("For Language (l)");
                Console.WriteLine("For History (h)");
                Console.WriteLine();
                Console.Write("Please Enter Student Branch: ");
                branchTest = Console.ReadLine().ToUpper();

                char dq = '"';

                switch (branchTest)
                {
                    case "M":
                        Console.WriteLine($"Selected, {dq}Math{dq} ");
                        branch = BRANCH.Math;
                        break;
                    case "S":
                        Console.WriteLine($"Selected, {dq}Science{dq} ");
                        branch = BRANCH.Science;
                        break;
                    case "L":
                        Console.WriteLine($"Selected, {dq}Language{dq} ");
                        branch = BRANCH.Language;
                        break;
                    case "H":
                        Console.WriteLine($"Selected, {dq}History{dq} ");
                        branch = BRANCH.History;
                        break;
                    default:
                        Console.WriteLine("invalid entry, please try again");
                        continue;
                }
                break;
            } while (true);

            Console.WriteLine();
            Console.WriteLine("the student has been successfully registered.");

            school.RegisterStudent(studnumber, firstname, lastname, branch);



        }

        static void RemoveStudent()
        {

            int number;
            Console.Write("Please enter the number to be deleted: ");
            try
            {
                number = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("invalid input. exiting...");
                return;
            }


            try
            {
                Student m1;
                m1 = school.Students.First(item => item.StudNumber == number);
                school.Students.Remove(m1);
            }
            catch (Exception)
            {
                Console.WriteLine("There is no such student.");
            }

            Console.WriteLine("The student has been successfully deleted. ");

        }



        static void WriteList(List<Student> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("no students to list ");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("      Student Name         Student LastName        Student Number      Student Branch");
            Console.WriteLine("-------------------------------------------------------------------------------------");
            foreach (Student item in list)
            {
                Console.WriteLine("      " + item.StudFirstName.PadRight(21) + item.StudLastName.PadRight(24) + item.StudNumber.ToString().PadRight(20) + item.Branch.ToString());
            }
            Console.WriteLine("-------------------------------------------------------------------------------------");


        }

    }
}
