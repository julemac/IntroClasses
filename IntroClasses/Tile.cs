namespace IntroClasses;

public class Tile
{
    private char _rep;
    private Character _occupant;
    private bool _occupied = false;

    public Tile(char rep)
    {
        _rep = rep;
    }

    public void Display()
    {
        if(!_occupied) Console.Write(_rep);
        if(_occupied) _occupant.Display();
    }
    
    public char GetRepresentation(){return _rep;}
    // public void Occupy(Character occupant)
    // {
    //     _occupied = true;
    //     _occupant = occupant;
    // }
    //
    // public void Unoccupy(){_occupied = false;_occupant = null;}
    //
    // public bool IsOccupied()
    // {
    //     return _occupant != null;
    // }
}