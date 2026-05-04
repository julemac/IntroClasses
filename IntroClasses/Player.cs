namespace IntroClasses;

public class Player : Character
{
    public Player(int x = 0, int y = 0) : base(x, y)
    {
        Display();
    }

    public override bool TakeTurn()
    {
        bool isPlaying = true;
        ConsoleKeyInfo input = Console.ReadKey(true);
        Console.SetCursorPosition(Position.X, Position.Y);
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