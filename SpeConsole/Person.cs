using System;

public abstract class Person : ISpecialization
{
    protected string Name { get; }
    protected string? MiddleName { get; set; }
    protected int Age { get; }
    protected Role Role { get; }
    public DateOfBirth? DateOfBirth { get; set; }
    public List<string>? Hobbies { get; set; }

    protected Person(string name, int age, Role role)
    {
        Name = name;
        Age = age;
        Role = role;
    }

    public abstract void EnjoyHobbies();

    public abstract void Specialize();

    public (string Name, Role Role) GetNameAndRole()
    {
        return (Name, Role);
    }
}
