using ConsoleAppProject_Course_.Enums;
using ConsoleAppProject_Course_.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject_Course_.Interfaces
{
    interface ICourseService
    {
        public List<Group> Groups { get; }
        public List<Student>  Students{ get;}
        public string CreateGroup(ClassCategory category,string line);
        public void GetGroups();
        public void EditGroups(string No, string newNo);
        public void GetGroupStudent(string no);
        public void GetAllStudents();
        
        public bool CreateStudent(string fullname, EducationType edutype,string groupno);

    }
}
