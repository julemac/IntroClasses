namespace IntroClasses;

public class Tile
{
    private readonly char _rep;
    public Character? Occupant = null;
    private bool _occupied = false;
    private readonly bool _walkable = true;
    public Item Item = null;

    public Tile(char rep)
    {
        this._rep = rep;
        if (this._rep == '#')
        {
            _walkable = false;
            this._rep = '▓';
        }
    }

    public void Display()
    {
        if (_occupied) Occupant.Display();
        else if (Item != null) Item.Display();
        else Console.Write(_rep);
    }

    public char GetRepresentation()
    {
        return _rep;
    }

    public bool CanBeOccupied()
    {
        return !_occupied && _walkable;
    }

    public void PlaceOnTile(Character occupant)
    {
        _occupied = true;
        this.Occupant = occupant;
    }

    public void PlaceOnTile(Item item)
    {
        this.Item = item;
    }

    public void RemoveOccupant()
    {
        _occupied = false;
        Occupant = null;
    }

    public bool IsOccupied()
    {
        return _occupied;
    }
}