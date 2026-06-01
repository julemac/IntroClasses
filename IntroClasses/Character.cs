namespace IntroClasses;

public abstract class Character
{
    protected Vector2D Position;
    private string _avatar;

    public Character(Map map, int x = 0, int y = 0, string avatar = "!")
    {
        Position = new Vector2D(x, y);
        _avatar = avatar;
        if(!map.PlaceOccupant(this)) Console.WriteLine("Could not add to map");
    }

    public void Display()
    {
        Console.SetCursorPosition(Position.X, Position.Y);
        Console.Write(_avatar);
    }

    public void FixBehind(Map map)
    {
        Console.SetCursorPosition(Position.X, Position.Y);
        Console.Write(map.GetTileRepresentation(Position.X, Position.Y));
    }

    //Move by diffX (horizontal) and by diffY (vertical) on map
    public void Move(int diffX, int diffY, Map map)
    {
        int targetX = Position.X + diffX;
        int targetY = Position.Y + diffY;
        if (map.CanOccupy(targetX, targetY))
        {
            map.RemoveOccupant(Position.X, Position.Y);
            Position.X = targetX;
            Position.Y = targetY;
            map.PlaceOccupant(this);
        }
        else if (map.IsOccupied(targetX, targetY))
        {
            Character? npc = map.GetTileOccupant(targetX, targetY);
            if (npc != null) npc.Interact();
        }
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

    public abstract void Interact();
}