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
        public Student CreatStudent(Student student)
        {
            foreach (var group in Groups) ;
            Students.Add(student);
            return student;
        }
        public CourseGroup CreateGroup(Category cat , bool isonline , int limit)
        {
            CourseGroup group = new CourseGroup(cat, isonline, limit);
            Groups.Add(group);
            return group;

        }
        public void NewGroup(Category category)
        {
            bool isoNline = Convert();
            category = new Category;
            Groups.Add(new_Groups);
        }
        public bool Convert()
        {
            Console.WriteLine("Group is online ?");
            Console.WriteLine("1.Yes ");
            Console.WriteLine("2.No");
            string answer = Console.ReadLine();
            Console.WriteLine(answer);
            bool isonline = false;
            Console.WriteLine(isonline);
            if (answer == "1")
            {
                isonline = true;
            }
            else if (answer == "2")
            {
                isonline= false;
            }
            return isonline;
        }
        public Category Programming()
        {
            Console.WriteLine("Group is online ?");
            Console.WriteLine("1.Programming ");
            Console.WriteLine("2 Desing");
            Console.WriteLine("3 SystemAdministration");
            string answer = Console.ReadLine();
            Category category = Category.Programming;

            if (answer == "1")
            {
                Category = Category.Programming;
                
            }
            else if (answer == "2")
            {
                category = Category.Desing;
            }
        }
        

            
        
        
       
            
    }
}
