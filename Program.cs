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
                // создаем два объекта User
                Student student1 = new Student { Name = "Balko"};
                Student student2 = new Student { Name = "Bestachenko" };
                Student student3 = new Student { Name = "Zayets" };
                Student student4 = new Student { Name = "Shabatura" };
                Student student5 = new Student { Name = "Yahnyschak" };
                Student student6 = new Student { Name = "Yanishevsky" };




                // добавляем их в бд
                db.Students.Add(student1);
                db.Students.Add(student2);
                db.Students.Add(student3);
                db.Students.Add(student4);
                db.Students.Add(student5);
                db.Students.Add(student6);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                // получаем объекты из бд и выводим на консоль
                var students = db.Students.ToList();
                Console.WriteLine("Список объектов:");
                foreach (Student s in students)
                {
                    Console.WriteLine($"{s.Id}.{s.Name} ");
                }
            }
            Console.Read();
        }
    }
}
