namespace IntroClasses;

public class Item
{
    protected Vector2D Position;
    private string _avatar;

    public Item(Map map, int x = 0, int y = 0, string avatar = "!")
    {
        Position = new Vector2D(x, y);
        _avatar = avatar;
    }

    public void Display()
    {
        Console.SetCursorPosition(Position.X, Position.Y);
        Console.Write(_avatar);
    }

    public void FixBehind(Map map)
    {
        Console.SetCursorPosition(Position.X, Position.Y);
        //Console.Write(map.GetTileRepresentation(Position.X, Position.Y));
    }

    public Vector2D GetPosition(){return Position;}
    
    public void Interact(Map map)
    {
        FixBehind(map);
    }
}