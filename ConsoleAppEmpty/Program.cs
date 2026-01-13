using GameEnums;


public class Program
{
    static void Main(string[] args)
    {
        Difficulty example = Difficulty.Medium;
        CharacterClass Character = CharacterClass.Mage;


        Console.WriteLine("Choose your difficulty");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine((Difficulty)i);
        }
        string response = Console.ReadLine();

        Console.WriteLine("Choose your class");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine((CharacterClass)i);
        }
        string response2 = Console.ReadLine();


        Console.WriteLine($"Selected Difficulty: {response}");
        Console.WriteLine($"Selected Class: {response2}");

    }
}

