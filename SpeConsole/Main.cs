public class MainClass
{
    public static void Main(string[] args)
    {
        var test_engineer = new Engineer("Chris", 30)
        {
            DateOfBirth = new DateOfBirth { Day = 1, Month = 1, Year = 1990 },
            Hobbies = new List<string> {}
        };

        var test_designer = new Designer("Timmah", 99)
        {
            DateOfBirth = new DateOfBirth { Day = 2, Month = 2, Year = 1992 },
            Hobbies = new List<string> { "timMaH!" }
        };

        var test_qa = new QA("FLUFFY", 5)
        {
            DateOfBirth = new DateOfBirth { Day = 3, Month = 3, Year = 2015 },
            Hobbies = new List<string> { "meowing", "eating", "sleeping", "HUNTING" }
        };

        var persons = new Person[] { test_engineer, test_qa, test_designer };

        foreach (var person in persons)
        {
            person.Specialize();
            person.EnjoyHobbies();
            var (name, role) = person.GetNameAndRole();
            if (name == "FLUFFY")
            {
                Console.WriteLine("FLUFFY is obviously a cat.");
            }
            else
            {
                Console.WriteLine($"{name} is a {role}.");
            }
            Console.WriteLine();
        }
    }
}
