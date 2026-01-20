using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolMasterGodProgram.Classes
{
    internal class Student
    {
        public string name;
        public int age;
        public string favSub;
        public Email email;

        public Student():this(0, "Unknown")
        {}
        public Student(int age, string name):this(name, age, "Unknown", new Email())
        {}
        
        public Student(string name, int age, string favSub, Email email)
        {
            this.name = name;
            this.age = age;
            this.favSub = favSub;
            this.email = email;
        }
    }
}
