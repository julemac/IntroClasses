namespace IntroClasses;

public class Tile
{
    private char _rep;
    private Character? _occupant = null;
    private bool _occupied = false;
    private readonly bool _walkable = true;

    public Tile(char rep)
    {
        _rep = rep;
        if (_rep == '#')
        {
            _walkable = false;
            _rep = '▓';
        }
    }

    public void Display()
    {
        if (!_occupied) Console.Write(_rep);
        else _occupant?.Display();
    }

    public char GetRepresentation()
    {
        return _rep;
    }

    public bool CanBeOccupied()
    {
        return !_occupied && _walkable;
    }

    public void Occupy(Character occupant)
    {
        _occupied = true;
        _occupant = occupant;
    }

    public void Unoccupy()
    {
        _occupied = false;
        _occupant = null;
    }

    public bool IsOccupied()
    {
        return _occupied;
    }
}