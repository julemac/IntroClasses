namespace IntroClasses;

public class Player
{
    //private int _x;
    //private int _y;
    private Vector2D _position;
    private string _avatar = "@";

    public Player(int x, int y)
    {
        _position = new Vector2D(x, y);
    }
    
    public void Display()
    {
        Console.SetCursorPosition(_position.X,  _position.Y);
        Console.Write(_avatar);
    }

    public void Move(int diffX, int diffY)
    {
        int targetX = _position.X + diffX;
        int targetY = _position.Y + diffY;
        if (targetX < Console.BufferWidth && targetX >= 0) _position.X =  targetX;
        if (targetY < Console.BufferHeight && targetY >= 0) _position.Y =  targetY;
    }


    public bool TakeTurn()
    {
        bool isPlaying = true;
        ConsoleKeyInfo input = Console.ReadKey(true);
        Console.SetCursorPosition(_position.X, _position.Y);
        Console.Write(" ");
        switch (input.Key)
        {
            case ConsoleKey.S:
                //Console.Write("A");
                Move(0, 1);
                break;
            case ConsoleKey.W:
                //Console.Write("HOP");
                Move(0, -1);
                break;
            case ConsoleKey.A:
                //Console.Write("TAP");
                //Move(-3, 0);
                Move(-1, 0);
                break;
            case ConsoleKey.D:
                //Console.Write("TUP");
                //Move(3, 0);
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