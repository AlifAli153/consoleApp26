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



        public CourseGroup(Category category, bool isOnline, int limit)
        {
            switch (category)
            {
                case Category.Programing:
                    No = $"P-{count}";
                    break;
                case Category.Desing:
                    No = $"D-{count}";
                    break;
                case Category.System_Administration:
                    No = $"SA-{count}";
                    break;
                    default:
                    break;
                    category = category;
                    isOnline = isOnline;
                    limit = limit;
                    if(IsOnline)
                    {
                        Limit = 15;

                    }
                    else
                    {
                        Limit = 10;
                    }


            }
        }
        
            


                        
        

    }


}
