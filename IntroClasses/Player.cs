namespace IntroClasses;

public class Player : Character
{
    private readonly Dictionary<ConsoleKey, Vector2D> _keyToDirection;
    private List<Item> _inventory;

    public Player(int x, int y, Dictionary<ConsoleKey, Vector2D> dict, Map map) : base(map, x, y, "@")
    {
        Display();
        _keyToDirection = dict;
        _inventory = [];
    }

    public override bool TakeTurn(Map map)
    {
        bool isPlaying = true;
        ConsoleKeyInfo input = Console.ReadKey(true);

        int prevX = Position.X, prevY = Position.Y;

        if (_keyToDirection.ContainsKey(input.Key))
            Move(_keyToDirection[input.Key], map);

        switch (input.Key)
        {
            case ConsoleKey.E:
                var tile = map.GetTile(Position.X, Position.Y);
                if (tile.HasItem())
                {
                    tile.GetItem()!.Interact(map);
                    _inventory.Add(tile.TakeItem()!);
                }
                break;
            case ConsoleKey.Q:
                Display();
                isPlaying = false;
                break;
        }

        FixTileRep(map, prevX, prevY);

        Display();
        return isPlaying;
    }

    public override void Interact(Map map)
    {
    }
}