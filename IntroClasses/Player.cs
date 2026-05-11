namespace IntroClasses;

public class Player : Character
{
    private readonly Dictionary<ConsoleKey, Vector2D> _keyToDirection;

    public Player(int x, int y, Dictionary<ConsoleKey, Vector2D> dict) : base(x, y, "@")
    {
        Display();
        _keyToDirection = dict;
    }

    public override bool TakeTurn()
    {
        bool isPlaying = true;
        ConsoleKeyInfo input = Console.ReadKey(true);
        Console.SetCursorPosition(Position.X, Position.Y);
        Console.Write(" ");

        if (_keyToDirection.ContainsKey(input.Key))
            Move(_keyToDirection[input.Key]);

        switch (input.Key)
        {
            case ConsoleKey.Q:
                // Display();
                isPlaying = false;
                break;
        }

        Display();
        return isPlaying;
    }
}