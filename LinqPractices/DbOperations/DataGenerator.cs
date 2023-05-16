using LinqPractices.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractices.DbOperations
{
    public class DataGenerator
    {
        public static void intialized()
        {
            using (var context = new LinqDbContext())
            {
                if (context.Students.Any())
                {
                    return;
                }

                context.Students.AddRange
                    (
                        new Student()
                        {
                            Name = "Ayşe",
                            SurName = "Yılmaz",
                            ClassId = 1,
                        },
                        new Student()
                        {
                            Name = "Deniz",
                            SurName = "Arda",
                            ClassId = 1,
                        },
                        new Student()
                        {
 
                            Name = "Umut",
                            SurName = "Arda",
                            ClassId = 2,
                        },
                        new Student()
                        {

                            Name = "Merve",
                            SurName = "Çalışkan",
                            ClassId = 2,
                        }
                    );
                context.SaveChanges();
            }
        }
    }
}
