using ConsoleApp26.Enums;
using ConsoleApp26.Student_classi;
using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp26.Enums;

namespace ConsoleApp26.Group_class
{
    internal class Group
    {
        public static int count = 200;
        public string No;
        public Category Cat;
        public string IsOnline;
        public int Limit;
        public List<Student> Students;
        

        public Group(string name, string surname, int groupno, Category cat, int limit, List <Student> students)
        {
            switch (cat)
            {
                case Category.programing:
                    cat = Category.programing;
                    break;
                case Category.Desing:
                    cat = Category.Desing;
                    break;
                case Category.System_Administration:
                    cat = Category.System_Administration;
                    break;
                default:
                    break;
        
            }
            cat = cat;

            Student student = new Student(name, surname, groupno);
            students.Add(student);
        }   

    }


}
