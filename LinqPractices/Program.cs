// See https://aka.ms/new-console-template for more information
using LinqPractices.DbOperations;
using LinqPractices.Entity;

DataGenerator.intialized();
LinqDbContext _context = new LinqDbContext();
var Students = _context.Students.ToList<Student>();
//Find();
Console.WriteLine("***** Find *****");
var student = _context.Students.Where(student => student.StudentId == 1).FirstOrDefault();
student = _context.Students.Find(2);
Console.WriteLine(student.Name);

// FirstOrDefault()

Console.WriteLine();
Console.WriteLine("***** FirstOrDefault *****");
student = _context.Students.Where(student=> student.SurName == "Arda").FirstOrDefault();
Console.WriteLine(student.Name);

student = _context.Students.FirstOrDefault(x => x.SurName == "Arda");
Console.WriteLine(student.Name);

// SingleOrDefault()

Console.WriteLine();
Console.WriteLine("***** SingleOrDefault *****");
student = _context.Students.SingleOrDefault(x => x.Name == "Deniz");
//student = _context.Students.SingleOrDefault(x => x.SurName == "Arda"); 2 singleordefault ta hata alınır
Console.WriteLine(student.SurName);
// ToList


Console.WriteLine();
Console.WriteLine("***** ToList *****");
var studentlist = _context.Students.Where(student=> student.ClassId == 2).ToList();
Console.WriteLine(studentlist.Count);

//OrderBy
Console.WriteLine();
Console.WriteLine("***** OrderBy *****");

var students = _context.Students.OrderBy(x => x.StudentId).ToList();
foreach (var st in students)
{
    Console.WriteLine(st.StudentId + " - " + st.Name + " - " + st.SurName);
}

//OrderByDescending
Console.WriteLine();
Console.WriteLine("***** OrderByDescending *****");

students = _context.Students.OrderByDescending(x => x.StudentId).ToList();
foreach (var st in students)
{
    Console.WriteLine(st.StudentId + " - " + st.Name + " - " + st.SurName);
}

// Anonymous Object Result
Console.WriteLine();
Console.WriteLine("***** Anonymous Object Result *****");

var anonymousObject = _context.Students
                    .Where(x => x.ClassId == 2)
                    .Select(x => new
                    {
                        Id = x.StudentId,
                        FullName = x.Name + " " + x.SurName
                    });
foreach (var item in anonymousObject)
{
    Console.WriteLine(item.Id + " - " + item.FullName);
}


