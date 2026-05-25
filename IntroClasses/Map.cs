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

    public bool IsInMap(int row, int column)
    {
        return column >= 0 && column < _tiles.Length && row >= 0 && row < _tiles[column].Length;
    }

    public bool CanOccupy(int row, int column)
    {
        return IsInMap(row, column) && _tiles[column][row].CanBeOccupied();
    }

    public bool CanOccupy(Vector2D start, Vector2D direction)
    {
        var goal = start + direction;
        return CanOccupy(goal.X, goal.Y);
    }

    public bool IsOccupied(int row, int column)
    {
        return IsInMap(row, column) && _tiles[column][row].IsOccupied();
    }

    public Character? GetTileOccupant(int row, int column)
    {
        return IsOccupied(row, column)? _tiles[column][row].Occupant() : null;
    }

    public bool PlaceOccupant(Character occupant, int x, int y)
    {
        if (CanOccupy(x, y))
        {
            _tiles[y][x].Occupy(occupant);
            return true;
        }

        return false;
    }

    public bool PlaceOccupant(Character occupant, Vector2D position)
    {
        return PlaceOccupant(occupant, position.X, position.Y);
    }

    public bool PlaceOccupant(Character occupant)
    {
        return PlaceOccupant(occupant, occupant.GetPosition());
    }

    public void RemoveOccupant(int row, int column)
    {
        if (IsInMap(row, column) && _tiles[column][row].IsOccupied())
        {
            _tiles[column][row].Unoccupy();
        }
    }
}