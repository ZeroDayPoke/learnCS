public class QA : Person
{
    public QA(string name, int age) : base(name, age, Role.QA)
    {
    }

    public override void EnjoyHobbies()
    {
        if (Hobbies != null && Hobbies.Count > 0)
        {
            List<string> sortedHobbies = new List<string>(Hobbies);
            sortedHobbies.Sort();
            sortedHobbies.Reverse();

            foreach (string hobby in sortedHobbies)
            {
                string modifiedHobby = ModifyHobbyString(hobby);
                Console.WriteLine((base.Name) + " is pleased by " + modifiedHobby);
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
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > 1)
            {
                string modifiedWord = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1, words[i].Length - 2) + words[i].Substring(words[i].Length - 1).ToUpper();
                words[i] = modifiedWord;
            }
        }
        return string.Join(" ", words);
    }

    public override void Specialize()
    {
        Console.WriteLine("Specializing in QA...");
    }
}
