namespace IntroClasses;

public class Program
{
    public static void Main()
    {
        Dictionary<ConsoleKey, Vector2D> keyToDirection;
        keyToDirection = new Dictionary<ConsoleKey, Vector2D>();
        keyToDirection[ConsoleKey.A] = new Vector2D(-1, 0);
        keyToDirection[ConsoleKey.D] = new Vector2D(1, 0);
        keyToDirection[ConsoleKey.W] = new Vector2D(0, -1);
        keyToDirection[ConsoleKey.S] = new Vector2D(0, 1);

        bool isPlaying = true;

        Player hero = new Player(3, 4, keyToDirection);

        List<Character> characters = [];
        characters.Add(new NPC(1, 2));
        characters.Add(hero);

        while (isPlaying)
        {
            foreach (Character character in characters)
                isPlaying = character.TakeTurn();
        }

        Console.WriteLine("Goodbye!");
    }
}