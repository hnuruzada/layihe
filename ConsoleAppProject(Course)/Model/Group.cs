using ConsoleAppProject_Course_.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject_Course_.Model
{
    class Group
    {
        public static int count = 1;
        public string No { get; set; }
        public ClassCategory Category { get; set; }
        public string IsLine { get; set; }
		public int Limit { get; set; }
		public List<Student> Students { get; set; }
		public Group(ClassCategory category,string line)
        {
            switch (category)
            {
                case ClassCategory.Programming:
                    No = "P" + count;
                    break;
                case ClassCategory.Design:
                    No = "D" + count;
                    break;
                case ClassCategory.SystemAdminstration:
                    No = "SA" + count;
                    break;
                default:
                    break;
            }
            Category = category;

            if(line.ToLower().Trim() == "online".ToLower().Trim())
            {
                Limit = 15;
            }
            else
            {
                if (line.ToLower() == "offline".ToLower())
                {
                    Limit = 10;
                }
            }
            IsLine = line;
            Students = new List<Student>();
            count++;
        }
      
        public override string ToString()
        {
            return $"<--{No}--> <--{Category}-->";
        }
    }
}
