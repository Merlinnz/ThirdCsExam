var teacher = new Teacher(1,"Murat",1234);
var teacher2 = new Teacher(2,"Galib",5678);


var teachers = new List<Teacher>();
teachers.Add(teacher);
teachers.Add(teacher2);
foreach (var item in teachers)
{
    System.Console.WriteLine($"{item.userId} {item.userName} {item.password}");
}

System.Console.WriteLine(new string('.',25));

var student = new Student(1,"John",243);
var student2 = new Student(2,"Hello", 245);

var students = new List<Student>();

students.Add(student);
students.Add(student2);
foreach (var item in students)
{
    System.Console.WriteLine($"{item.userId} {item.userName} {item.password}");
}

