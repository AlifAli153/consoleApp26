using ConsoleApp26.Enums;
using ConsoleApp26.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace ConsoleApp26.CourseService
{
    class CourceServicecs
    {
        private List<CourseGroup> _groups = new List<CourseGroup>();
        public List<CourseGroup> Groups => _groups;
        public List<Student> Students = new List<Student>();
        public Category category;
        public void AllStudentList()
        {
            foreach (var group in Groups) ;
        }
        public void CreatStudent()
        {
            foreach (var group in Groups) ;
            Students.Add(student);
            return Student;
        }
        public CourseGroup CreateGroup(Category cat , bool isonline , int limit)
        {
            CourseGroup group = new CourseGroup(cat, isonline, limit);
            Groups.Add(group);
            return group;

        }
    }
}
