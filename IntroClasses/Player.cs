namespace IntroClasses;

public class Player : Character
{
    private readonly Dictionary<ConsoleKey, Vector2D> _keyToDirection;

    public Player(int x, int y, Dictionary<ConsoleKey, Vector2D> dict, Map map) : base(map, x, y, "@")
    {
        Display();
        _keyToDirection = dict;
    }

    public override bool TakeTurn(Map map)
    {
        bool isPlaying = true;
        ConsoleKeyInfo input = Console.ReadKey(true);
        
        FixBehind(map);

        if (_keyToDirection.ContainsKey(input.Key))
            Move(_keyToDirection[input.Key],map);

        switch (input.Key)
        {
            case ConsoleKey.Q:
                Display();
                isPlaying = false;
                break;
        }

        Display();
        return isPlaying;
    }

    public override void Interact() {}
}