using ConsoleAppProject_Course_.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleAppProject_Course_.Services
{
    static class MenuService
    {
        public static CourseService CourseService = new CourseService();
         public static void CreateGroupMenu()
        {
             Console.WriteLine("Select this one Online or Offline");
            string line = Console.ReadLine();
            if (line.ToLower().Trim() == "online".ToLower().Trim() || line.ToLower().Trim() == "offline".ToLower().Trim())
            {
                Console.WriteLine("Select category");
				foreach (var c in Enum.GetValues(typeof(ClassCategory)))
                {
                    Console.WriteLine($"{(int)c}.{c}");
                }
                int category;
                string categoryStr = Console.ReadLine();
                bool categoryResult = int.TryParse(categoryStr, out category);
                if (categoryResult)
                {
                    switch (category)
                    {
                        case 1:
                            string No = CourseService.CreateGroup(ClassCategory.Programming,line);
                            Console.WriteLine($"{No}. Group sucessfully created");
                            break;
                        case 2:
                            No = CourseService.CreateGroup(ClassCategory.Design, line);
                            Console.WriteLine($"{No}. Group sucessfully created");
                            break;
                        case 3:
                            No = CourseService.CreateGroup(ClassCategory.SystemAdminstration,line);
                            Console.WriteLine($"{No}. Group sucessfully created");
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Select valid group status please");
            }
         }
        public static void EditGroupsMenu()
        {
            Console.WriteLine("Please enter group number that you want to change:");
            string groupNo = Console.ReadLine();
            Console.WriteLine("Please enter new group number:");
            string newgroupNo = Console.ReadLine();
            CourseService.EditGroups(groupNo, newgroupNo);

        }
        public static void GetGroupsMenu()
        {
            CourseService.GetGroups();
        }
        public static void GetGroupStudentsMenu()
        {
            Console.WriteLine("Please enter group no");
            string no = Console.ReadLine();

            CourseService.GetGroupStudent(no.ToUpper());



        }
        public static void CreateStudentMenu()
        {            
            Console.WriteLine("Please enter students informations");
            string studfullname = Console.ReadLine();

            Console.WriteLine("please insert group no");
            string no = Console.ReadLine();

            foreach (var e in Enum.GetValues(typeof(EducationType)))
            {
                Console.WriteLine($"{(int)e}.{e}");
            }
            int edutype;
            string edutyoeStr = Console.ReadLine();
            bool eduResult = int.TryParse(edutyoeStr, out edutype);
            if (eduResult)
            {

                switch (edutype)
                {
                    case 1:
                        bool isTrue = CourseService.CreateStudent(studfullname, EducationType.Guarranted, no.ToUpper());
                        if (isTrue)
                        {
                            Console.WriteLine($"{studfullname} student created");
                        }

                        break;
                    case 2:
                        isTrue = CourseService.CreateStudent(studfullname, EducationType.non_Guarranted, no.ToUpper());
                        if (isTrue)
                        {
                            Console.WriteLine($"{studfullname} student created");
                        }

                        break;
                    default:
                        break;
                }
            }


        }
        public static void GetAllStudentsMenu()
		{
            CourseService.GetAllStudents();
		}
    }
}