/*
- We use the struct structure to combine one or more types of data.
- Value type.
- Used on small scale data.
- No inheritance.
- Interface supports inheritance.
- No boxing/unboxing.
- Parameterized constructor method, constants, fields, properties can be used.
*/


// Struct use first

using System.Threading.Channels;

Student student1 = new Student();
student1.Number = 10;
student1.Name = "Ali";
student1.Surname = "Oz";
student1.Gender = true;



//  Struct use second
var student2 = new Student()
{
    Number = 20,
    Name = "Fatma",
    Surname = "Dag",
    Gender = false
};



// Struct use three

// var student3 = new Student(30, "Mehmet", "Avsar", true);

// var student4 = new Student(40, "Asaf", "Karlidag");


Console.WriteLine(student1);
Console.WriteLine(student2);
//Console.WriteLine(student3);
//Console.WriteLine(student4);

List<Student> students = new List<Student>()
{
    new Student(30,"Mehmet","Avsar",true),
    new Student(40,"Asaf","Karlidag")

};

students.ForEach(s => Console.WriteLine(s));


/*
foreach (var student in students)
{
    Console.WriteLine(student);
}
*/