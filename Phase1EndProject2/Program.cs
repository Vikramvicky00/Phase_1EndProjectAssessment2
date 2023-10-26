using System;
using System.Collections.Generic;

namespace Phase1EndProject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
                List<Teacher> teachers = TeacherManagement.LoadTeacherData();
                while (true)
                {
                    Console.WriteLine("Welcome to Rainbow School Teacher Data System");
                    Console.WriteLine("1. Display All Teachers");
                    Console.WriteLine("2. Add New Teacher");
                    Console.WriteLine("3. Update Teacher Data");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("Enter your Choice");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                        TeacherManagement.DisplayAllTeachers(teachers);
                            break;
                        case 2:
                        TeacherManagement.AddNewTeacher(teachers);
                            break;
                        case 3:
                            TeacherManagement.UpdateTeacherData(teachers);
                            break;
                        case 4:
                        TeacherManagement.SaveTeacherData(teachers);
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                    Console.Write("Do you want to continue (yes/no)?:");
                    string continueChoice = Console.ReadLine();
                    if (continueChoice.ToLower() != "yes")
                    {
                        break;
                    }
                }
            }
        }
    }

