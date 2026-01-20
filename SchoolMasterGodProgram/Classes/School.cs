using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolMasterGodProgram.Classes
{
    internal class School
    {
        public string name;
        public List<StudentGroup> groups = new List<StudentGroup>();

        public void addGroup()
        {
            groups.Add(new StudentGroup());
        }
        public void addGroup(StudentGroup group)
        {
            groups.Add(group);
        }
    }
}
