namespace IntroClasses;

public class NPC : Character
{
    //private Random random = new Random(1234);
    private bool _onoff = true;

    private List<Vector2D> availableDirections =
    [
        new Vector2D(-1, 0),
        new Vector2D(1, 0),
        new Vector2D(0, -1),
        new Vector2D(0, 1)
    ];

    public NPC(int x, int y, Map map) : base(map, x, y, "?")
    {
       Display();
    }

    public override bool TakeTurn(Map map)
    {
        int prevX = Position.X, prevY = Position.Y;
        

        int index = Random.Shared.Next(0, availableDirections.Count);
        //int index = random.Next(0, availableDirections.Count);
        Move(availableDirections[index], map);

        FixTileRep(map,prevX, prevY);
        
        Display();
        
        return true;
    }

    public override void Interact(Map map)
    {
        Console.SetCursorPosition(Position.X, Position.Y);
        if (_onoff)
        {
            _avatar = "!";
            _onoff = false;
        }
        else
        {
            _avatar = "?";
            _onoff = true;
        }
    }
}