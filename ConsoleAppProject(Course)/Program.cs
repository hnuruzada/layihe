using ConsoleAppProject_Course_.Enums;
using ConsoleAppProject_Course_.Services;
using System;

namespace ConsoleAppProject_Course_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************");
            Console.WriteLine("Welcome to the Course");
            Console.WriteLine();
            int selection;

            do
            {
                Console.WriteLine("1.Create Group");
                Console.WriteLine("2.Get Groups");
                Console.WriteLine("3.Edit Group");
                Console.WriteLine("4.Get Group Students");
                Console.WriteLine("5.Get All Students");
                Console.WriteLine("6.Create Student");
                Console.WriteLine("0.Exit");
                string selectStr = Console.ReadLine();

                bool result = int.TryParse(selectStr, out selection);
                if (result)
                {
                    switch (selection)
                    {
                        case 1:
                            MenuService.CreateGroupMenu();
                            break;
                        case 2:
                            MenuService.GetGroupsMenu();
                            break;
                        case 3:
                            MenuService.EditGroupsMenu();
                            break;
                        case 4:
                            MenuService.GetGroupStudentsMenu();
                            break;
                        case 5:
                            MenuService.GetAllStudentsMenu();
                            break;
                        case 6:
                           MenuService.CreateStudentMenu();
                            break;
                        case 0:
                            break;
                    }
                }

            } while (selection!=0);
        }
    }
}
