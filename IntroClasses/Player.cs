namespace IntroClasses;

public class Player
{
    private int _x;
    private int _y;
    private string _avatar = "@";

    public int GetPositionX()
    {
        return _x;
    }

    public int GetPositionY()
    {
        return _y;
    }

    public void Display()
    {
        Console.SetCursorPosition(_x, _y);
        Console.Write(_avatar);
    }

    public void Move(int diffX, int diffY)
    {
        int targetX = _x + diffX;
        int targetY = _y + diffY;
        if (targetX < Console.BufferWidth && targetX >= 0) _x =  targetX;
        if (targetY < Console.BufferHeight && targetY >= 0) _y =  targetY;
    }


    public bool TakeTurn()
    {
        bool isPlaying = true;
        ConsoleKeyInfo input = Console.ReadKey(true);
        Console.SetCursorPosition(_x, _y);
        Console.Write(".");
        switch (input.Key)
        {
            case ConsoleKey.S:
                Move(0, 1);
                break;
            case ConsoleKey.W:
                Move(0, -1);
                break;
            case ConsoleKey.A:
                Move(-1, 0);
                break;
            case ConsoleKey.D:
                Move(1, 0);
                break;
            case ConsoleKey.Q:
                // Display();
                isPlaying = false;
                break;
        }

        Display();
        return isPlaying;
    }
}