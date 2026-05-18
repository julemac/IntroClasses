namespace IntroClasses;

public abstract class Character
{
    protected Vector2D Position;
    private string _avatar;

    public Character(int x = 0, int y = 0, string avatar = "!")
    {
        Position = new Vector2D(x, y);
        _avatar = avatar;
    }

    public void Display()
    {
        Console.SetCursorPosition(Position.X, Position.Y);
        Console.Write(_avatar);
    }

    public void fixBehind(Map map)
    {
        Console.SetCursorPosition(Position.X, Position.Y);
        Console.Write(map.GetTileRepresentation(Position.X, Position.Y));
    }

    public void Move(int diffX, int diffY, Map map)
    {
        // if (map.CanOccupy(diffX, diffY))
        // {
        // }
        int targetX = Position.X + diffX;
        int targetY = Position.Y + diffY;
        if (targetX < Console.BufferWidth && targetX >= 0) Position.X = targetX;
        if (targetY < Console.BufferHeight && targetY >= 0) Position.Y = targetY;
    }

    public void Move(Vector2D diff, Map map)
    {
        Move(diff.X, diff.Y, map);
    }

    public abstract bool TakeTurn(Map map);

    public Vector2D GetPosition()
    {
        return Position;
    }
}