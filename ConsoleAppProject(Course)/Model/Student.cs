using ConsoleAppProject_Course_.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject_Course_.Model
{
    class Student
    {
        public string FullName { get; set; }
        public EducationType EduType { get; set; }
        public string GroupNo { get; set; }
        public Student(string fullname,EducationType edutype,string groupno)
        {
            FullName = fullname;
            EduType = edutype;
            GroupNo = groupno;
        }
        public override string ToString()
        {

            return $"{FullName}   {EduType}  {GroupNo} ";
        }
    }
}
