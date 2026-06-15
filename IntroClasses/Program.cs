namespace IntroClasses;

public class Program
{
    public static void Main()
    {
        Console.Clear();
        Console.CursorVisible = false;
        
        Dictionary<ConsoleKey, Vector2D> keyToDirection;
        keyToDirection = new Dictionary<ConsoleKey, Vector2D>();
        keyToDirection[ConsoleKey.A] = new Vector2D(-1, 0);
        keyToDirection[ConsoleKey.D] = new Vector2D(1, 0);
        keyToDirection[ConsoleKey.W] = new Vector2D(0, -1);
        keyToDirection[ConsoleKey.S] = new Vector2D(0, 1);

        bool isPlaying = true;

        Map map = new Map();
        
        List<Character> characters = [];
        characters.Add(new NPC(1, 1, map));
        //characters.Add(new NPC(13, 8));
        characters.Add(new Player(6, 1, keyToDirection, map));

        Item item = new Item(map, 4, 5, "#");

        map.Display();

        while (isPlaying)
        {
            foreach (Character character in characters)
                isPlaying = character.TakeTurn(map);
        }

        Console.WriteLine("Goodbye!");
    }
}