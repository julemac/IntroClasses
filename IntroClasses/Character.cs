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

    public void Move(int diffX, int diffY)
    {
        int targetX = Position.X + diffX;
        int targetY = Position.Y + diffY;
        if (targetX < Console.BufferWidth && targetX >= 0) Position.X = targetX;
        if (targetY < Console.BufferHeight && targetY >= 0) Position.Y = targetY;
    }

    public void Move(Vector2D diff)
    {
        Move(diff.X, diff.Y);
    }

    public abstract bool TakeTurn();
}