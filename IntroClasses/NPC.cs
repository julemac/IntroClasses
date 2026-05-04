namespace IntroClasses;

public class NPC : Character
{
    public NPC(int x, int y) : base(x, y, "?")
    {
        Display();
    }

    public override bool TakeTurn()
    {
        Console.SetCursorPosition(Position.X, Position.Y);
        Console.Write(" ");
        Move(1, 0);
        Display();
        return true;
    }
}