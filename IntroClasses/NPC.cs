namespace IntroClasses;

public class NPC : Character
{
    private Random random = new Random(1234);

    private List<Vector2D> availableDirections =
    [
        new Vector2D(-1, 0),
        new Vector2D(1, 0),
        new Vector2D(0, -1),
        new Vector2D(0, 1)
    ];

    public NPC(int x, int y) : base(x, y, "?")
    {
        Display();
    }

    public override bool TakeTurn()
    {
        Console.SetCursorPosition(Position.X, Position.Y);
        Console.Write(" ");


        //int index = Random.Shared.Next(0, availableDirections.Count);
        int index = random.Next(0, availableDirections.Count);
        Move(availableDirections[index]);
        Display();
        return true;
    }
}