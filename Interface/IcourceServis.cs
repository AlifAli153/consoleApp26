using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp26.Interface
{
    interface IcourceServis
    {
        public void NewGroup(Enum Category );
        public void EditGroup(string no, string name);
        public void GroupList(string no,  Enum Category, int Limit);
        public void AllStudentList(string fullname, string no, bool isonline);
        public void GroupListStudent(string fullname, string no, int Limit);
        public void CreatedStudent(string fullname, string groupno,bool type);
        

        
    }
}
