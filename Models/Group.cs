using ConsoleApp26.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp26.Enums;

namespace ConsoleApp26.Models
{ 
      
    class CourseGroup
{
    public Category Cat { get; set; }

        public static int count = 200;
        public string No;
        public bool IsOnline { get; set; }
        public int Limit { get; set; }
        public List<Student> Students;



        public CourseGroup(Category category, bool isOnline, int limit  )
        {
            Cat = category;
            IsOnline = isOnline;
            Limit = limit;
            No = No;
        }

    }


}
