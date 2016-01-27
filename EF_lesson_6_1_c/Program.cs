using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lesson_6_1_c
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FluentContext db = new FluentContext())
            {
                Phone p1 = new Phone { Name = "Samsung Galaxy S5", Price = 20000 };
                Phone p2 = new Phone { Name = "Samsung Galaxy S4", Price = 15000 };
                Phone p3 = new Phone { Name = "iPhone5", Price = 28000 };
                Phone p4 = new Phone { Name = "iPhone 4S", Price = 23000 };

                db.Phones.AddRange(new List<Phone>() { p1, p2, p3, p4 });
                db.SaveChanges();

                var phones = db.Phones.Where(p => p.Name == "Samsung Galaxy S5");
                foreach (Phone p in phones)
                    Console.WriteLine("{0}.{1} - {2}", p.Ident, p.Name, p.Price);
            }
            Console.ReadLine();
        }
    }
}
