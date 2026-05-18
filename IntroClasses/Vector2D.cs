namespace IntroClasses;

public struct Vector2D
{
    public int X;
    public int Y;

    public Vector2D(int x = 0, int y = 0)
    {
        X = x;
        Y = y;
    }

    public static Vector2D operator +(Vector2D a, Vector2D b)
    {
        return new Vector2D(a.X + b.X, a.Y + b.Y);
    }
}