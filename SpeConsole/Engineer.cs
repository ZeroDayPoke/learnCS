public class Engineer : Person
{
    public Engineer(string name, int age) : base(name, age, Role.Engineer)
    {
    }

    public override void EnjoyHobbies()
    {
        if (Hobbies != null && Hobbies.Count > 0)
        {
            List<string> sortedHobbies = new List<string>(Hobbies);
            sortedHobbies.Sort();

            foreach (string hobby in sortedHobbies)
            {
                string uppercasedHobby = hobby.ToUpper();
                Console.WriteLine((base.Name) + " go herd on " + uppercasedHobby);
            }
        }
        else
        {
            Console.WriteLine((base.Name) + " has no hobbies to enjoy. :(");
        }
    }

    public override void Specialize()
    {
        Console.WriteLine("Specializing in engineering...");
    }
}
