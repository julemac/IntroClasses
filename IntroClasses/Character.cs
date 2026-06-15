namespace IntroClasses;

public abstract class Character : GameObject
{
    // protected Vector2D Position;
    // protected string _avatar;

    public Character(Map map, int x = 0, int y = 0, string avatar = "!") : base(map, x, y, avatar)
    {
        // Position = new Vector2D(x, y);
        // _avatar = avatar;
        if(!map.PlaceOnMap(this)) Console.WriteLine("Could not add to map");
    }

    // public void Display()
    // {
    //     Console.SetCursorPosition(Position.X, Position.Y);
    //     Console.Write(_avatar);
    // }
    //
    // public void FixTileRep(Map map, int row, int column)
    // {
    //     Console.SetCursorPosition(row, column);
    //     //Console.Write(map.GetTileRepresentation(Position.X, Position.Y));
    //     map.GetTileRepresentation(row, column);
    //     
    // }

    //Move by diffX (horizontal) and by diffY (vertical) on map
    public void Move(int diffX, int diffY, Map map)
    {
        int targetX = Position.X + diffX;
        int targetY = Position.Y + diffY;

        if (!map.IsInMap(targetX, targetY)) return;
        Tile targetTile = map.GetTile(targetX, targetY);
        
        if(targetTile.CanBeOccupied())
        {
            map.GetTile(Position.X, Position.Y).RemoveOccupant();
            Position.X = targetX;
            Position.Y = targetY;
            targetTile.PlaceOnTile(this);
        }
        else if (targetTile.IsOccupied())
        {
            if (targetTile.IsOccupied()) targetTile.GetOccupant()!.Interact(map);
        }
    }

    public void Move(Vector2D diff, Map map)
    {
        Move(diff.X, diff.Y, map);
    }

    public abstract bool TakeTurn(Map map);
}