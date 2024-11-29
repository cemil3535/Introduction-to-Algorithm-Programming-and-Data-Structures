/*
- We use the struct structure to combine one or more types of data.
- Value type.
- Used on small scale data.
- No inheritance.
- Interface supports inheritance.
- No boxing/unboxing.
- Parameterized constructor method, constants, fields, properties can be used.
*/

public struct Student
{
    // Constructor
    public Student(int number, string name, string surname, bool gender = true)
    {
        // The constructor method will be run automatically when the object is created.
        Number = number;
        Name = name;
        Surname = surname;
        Gender = gender;
    }

    // Property
    public int Number { get; set; } 
    public string Name { get; set; }
    public string Surname { get; set; }
    public bool Gender { get; set; }


    // override
    public override string ToString()
    {
        return $"{Number,-5} " +
            $"{Name,-10} " +
            $"{Surname,-10} " +
            string.Format("{0,-8}", Gender == true ? "Male" : "Female");         
    }
}



