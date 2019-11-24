using System;
using System.Linq;

namespace TestPGForEF

{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
               

                Student student1 = new Student { Name = "Balko"};
                Student student2 = new Student { Name = "Bestachenko" };
                Student student3 = new Student { Name = "Zaiets" };
                Student student4 = new Student { Name = "Shabatura" };
                Student student5 = new Student { Name = "Yahnyschak" };
                Student student6 = new Student { Name = "Yanishevsky" };

              
                    db.Students.Add(student1);
                    db.Students.Add(student2);
                    db.Students.Add(student3);
                    db.Students.Add(student4);
                    db.Students.Add(student5);
                    db.Students.Add(student6);
                db.SaveChanges();
               Console.WriteLine("List was done successfully ");
                

                
                var students = db.Students.ToList();
                
                Console.WriteLine("List of Students:");
                foreach (Student s in students)
                {
                    Console.WriteLine($"{s.Id}.{s.Name} ");
                }
            }
            Console.Read();
        }
    }
}
