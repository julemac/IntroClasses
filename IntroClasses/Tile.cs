namespace IntroClasses;

public class Tile
{
    private readonly char _rep;
    private Character? _occupant = null;
    private bool _occupied = false;
    private readonly bool _walkable = true;
    private Item? _item = null;

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
        if (_occupied) _occupant.Display();
        else if (_item != null) _item.Display();
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
        this._occupant = occupant;
    }

    public void PlaceOnTile(Item item)
    {
        this._item = item;
    }

    public void RemoveOccupant()
    {
        _occupied = false;
        _occupant = null;
    }

    public bool IsOccupied()
    {
        return _occupied;
    }

    public Character? GetOccupant()
    {
        return _occupant;
    }

    public Item? TakeItem()
    {
        if (!HasItem()) throw new Exception("Tile has no item");
        Item item = _item!;
        _item = null;
        return item;
    }

    public bool HasItem()
    {
        return _item != null;
    }

    public Item? GetItem()
    {
        return _item;
    }
}