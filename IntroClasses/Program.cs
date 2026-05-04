namespace IntroClasses;

public class Program
{
    public static void Main()
    {
        bool isPlaying = true;

        Player hero = new Player(3, 4);

        List<Character> characters = new List<Character>();
        characters.Add(hero);
        characters.Add(new NPC(1, 2));

        while (isPlaying)
        {
            foreach (Character character in characters)
                isPlaying = character.TakeTurn();
        }

        Console.WriteLine("Goodbye!");
    }
}