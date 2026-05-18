namespace IntroClasses;

public class Map
{
    private string _source = "map_1.txt";
    private string[] _map;
    private Tile[][] _tiles;

    public Map()
    {
        _map = File.ReadAllLines(_source);

        _tiles = new Tile[_map.Length][];

        for (int rowIndex = 0; rowIndex < _map.Length; rowIndex++)
        {
            _tiles[rowIndex] = new Tile[_map[rowIndex].Length];

            for (int columnIndex = 0; columnIndex < _map[rowIndex].Length; columnIndex++)
                _tiles[rowIndex][columnIndex] = new Tile(_map[rowIndex][columnIndex]);
        }
    }

    public void Display()
    {
        Console.SetCursorPosition(0, 0);
        foreach (Tile[] tileLine in _tiles)
        {
            foreach (Tile tile in tileLine)
                tile.Display();
            
            Console.WriteLine();
        }
    }
    
    public char GetTileRepresentation(int column, int row)
    {
        if (!(row >= 0 && row < _tiles.Length && column >= 0 && column < _tiles[row].Length)) return ' ';
        
        return _tiles[row][column].GetRepresentation();
    }

    // public bool CanOccupy(int x, int y)
    // {
    //     return y >= 0 && y < _tiles.Length && x >= 0 && x < _tiles[y].Length && !_tiles[y][x].IsOccupied();
    // }
    //
    // public bool CanOccupy(Vector2D start, Vector2D direction)
    // {
    //     var goal = start + direction;
    //     return CanOccupy(goal.X, goal.Y);
    // }
    //
    //
    // public bool placeOccupant(Character occupant, int x, int y){
    //     if (CanOccupy(x,y))
    //     {
    //         _tiles[y][x].Occupy(occupant);
    //         return true;
    //     }
    //     return false;
    // }
    //
    // public bool placeOccupant(Character occupant, Vector2D position)
    // {
    //     return placeOccupant(occupant, position.X, position.Y);
    // }
    //
    // public bool placeOccupant(Character occupant)
    // {
    //     return placeOccupant(occupant,occupant.GetPosition());
    // }
}