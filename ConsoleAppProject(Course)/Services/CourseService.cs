using ConsoleAppProject_Course_.Enums;
using ConsoleAppProject_Course_.Interfaces;
using ConsoleAppProject_Course_.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject_Course_.Services
{
    class CourseService : ICourseService
    {
        private List<Group> _groups = new List<Group>();
        public List<Group> Groups => _groups;

        private List<Student> _students = new List<Student>();
        public List<Student> Students => _students;

        public string CreateGroup(ClassCategory category, string line)
        {
            Group group = new Group(category, line);
            _groups.Add(group);
            return group.No.ToUpper();
        }
        public void EditGroup(string no, string newNo)
        {
            Group existedGroup = null;
            foreach (Group group in _groups)
            {
                if (group.No.ToUpper().Trim() == no.ToUpper().Trim())
                {
                    existedGroup = group;
                    break;
                }
            }
            if (existedGroup == null)
            {
                Console.WriteLine($"{no.ToUpper()} group doesnt exist");
                return;
            }
            foreach (Group group in _groups)
            {
                if (group.No.ToUpper().Trim() == newNo.ToLower().Trim())
                {
                    Console.WriteLine($"{newNo.ToUpper()} group already exists");
                    return;
                }

            }
            existedGroup.No = newNo.ToUpper().Trim();
            Console.WriteLine($"{no.ToUpper()} succesfully updated to {newNo.ToUpper()}");
        }

       

        

       

       

		public void GetGroups()
		{

            if (Group.count == 0)
            {
                Console.WriteLine("There is no any group");
            }
            foreach (Group group in _groups)
            {

                Console.WriteLine(group);
            }
        }

		public void EditGroups(string No, string newNo)
		{
			throw new NotImplementedException();
		}

		public void GetGroupStudent(string no)
		{
            Group group = _groups.Find(c => c.No.ToUpper().Trim() == no.ToUpper().Trim());

            if (group == null)
            {
                Console.WriteLine($"{no}group doesnt exist");
            }
            else
            {
                if (group.Students.Count == 0)
                {
                    Console.WriteLine($"There is no any student in {group.No} ");
                    return;
                }

                foreach (Student student in group.Students)
                {
                    {

                        Console.WriteLine($"{student.FullName}  {student.GroupNo} {student.EduType}");

                    }
                }
            }
        }

		public void GetAllStudents()
		{

            if (_students.Count == 0)
            {
                Console.WriteLine("There is no any student");
            }
            else
            {
                foreach (Student student in _students)
                {
                    Console.WriteLine(student);

                }
            }
        }

		public bool CreateStudent(string fullname, EducationType edutype, string groupno)
		{
            Student student1 = new Student(fullname, edutype, groupno.ToUpper());
            Group group = _groups.Find(c => c.No.ToUpper().Trim() == groupno.ToUpper().Trim());
            if (group == null || group.Limit <= group.Students.Count)
            {
                if (group == null)
                {

                    Console.WriteLine($"{groupno} group does not exist");

                }
                else
                {
                    Console.WriteLine("Your limit is full. You can not add any other students");
                }

                return false;
            }

            else
            {
                group.Students.Add(student1);
                _students.Add(student1);
                return true;
            }
        }
	}
}
