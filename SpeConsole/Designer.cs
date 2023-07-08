public class Designer : Person
{
    public Designer(string name, int age) : base(name, age, Role.Designer)
    {
    }


    public override void EnjoyHobbies()
    {
        if (Hobbies != null && Hobbies.Count > 0)
        {
            foreach (string hobby in Hobbies)
            {
                string modifiedHobby = ModifyHobbyString(hobby);
                Console.WriteLine((base.Name) + " UWUs " + modifiedHobby);
            }
        }
        else
        {
            Console.WriteLine((base.Name) + " has no hobbies to enjoy. :(");
        }
    }


    private string ModifyHobbyString(string hobby)
    {
        string[] words = hobby.Split(' ');
        Array.Reverse(words);

        for (int i = 0; i < words.Length; i++)
        {
            words[i] = words[i].ToUpper();
        }

        return string.Join("", words);
    }

    public override void Specialize()
    {
        Console.WriteLine("Specializing in design...");
    }
}
