namespace IntroClasses;

public class Player
{
    private int x;
    private int y;
    private string avatar = "@";

    public void Display()
    {
        Console.WriteLine(avatar);
        Console.WriteLine($"Position: {x}, {y}");
    }

    public void Move(int diffX, int diffY)
    {
        x += diffX;
        y += diffY;
    }
}
