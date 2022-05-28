using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstStudentsDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var list = new StudentsList())
            {
                // Create and save a new student
                Console.Write("Adding new student... ");



                var student = new Student { StudentName = "Javier" };
                list.Students.Add(student);
                list.SaveChanges();

                //Displaying all students in database
                var query = from b in list.Students
                            orderby b.StudentName
                            select b;

                Console.WriteLine("Student added to registry.");
                foreach (var item in query)
                {
                    Console.WriteLine(item.StudentName);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
            }
        }
    }

    public class Student
    {
        //parameters of a each student in DB
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        //public int StudentAge { get; set; }
    }

    public class StudentsList : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
