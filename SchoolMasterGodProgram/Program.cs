using SchoolMasterGodProgram.Classes;

namespace SchoolMasterGodProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<School> schools = new List<School>();

            schools.Add(new School());
            schools[0].name = "Falufrigymnasiet";
            schools[0].addGroup();
            schools[0].addGroup();
            
            
            schools[0].groups[0].name = "Te24";
            schools[0].groups[0].students.Add(new Student(22, "Sebastian"));
            schools[0].groups[0].students.Add(new Student(12,"A"));
            schools[0].groups[0].students.Add(new Student(13,"B"));
            schools[0].groups[0].students.Add(new Student(14,"C"));
            schools[0].groups[0].students.Add(new Student(15,"D"));
            schools[0].groups[0].students.Add(new Student(16,"E"));
            schools[0].groups[0].students.Add(new Student(17,"F"));
            schools[0].groups[0].students.Add(new Student(18,"G"));
            schools[0].groups[0].students.Add(new Student(19,"H"));
            schools[0].groups[0].students.Add(new Student(20,"I"));
            schools[0].groups[0].students.Add(new Student(11,"J"));
            schools[0].groups[0].students.Add(new Student(10,"K"));
            schools[0].groups[0].students.Add(new Student(11,"L"));
            schools[0].groups[0].students.Add(new Student(15,"M"));
            schools[0].groups[0].students.Add(new Student(13,"N"));
            schools[0].groups[0].students.Add(new Student(91,"O"));
            schools[0].groups[0].students.Add(new Student(51,"P"));
            schools[0].groups[0].students.Add(new Student(16,"Q"));
            schools[0].groups[0].students.Add(new Student(12,"R"));
            
            schools[0].groups[1].name = "Vo12";


            schools.Add(new School());
            schools[1].name = "Bjursåsskolan";
            schools[1].groups.Add(new StudentGroup());
            schools[1].groups[0].name = "8B";
            schools[1].groups[0].students.Add(new Student());



            foreach (var school in schools)
            {
                Console.WriteLine(school.name);
                foreach(var group in school.groups)
                {
                    Console.WriteLine(group.name);
                    foreach(var student in group.students)
                    {
                        Console.WriteLine(student.name);
                    }
                }
            }
        }
    }
}
