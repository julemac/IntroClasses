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

    public void GetTileRepresentation(int column, int row)
    {
        if (!(row >= 0 && row < _tiles.Length && column >= 0 && column < _tiles[row].Length)) Console.Write(' ');
        _tiles[row][column].Display();
    }

    public bool IsInMap(int row, int column)
    {
        return column >= 0 && column < _tiles.Length && row >= 0 && row < _tiles[column].Length;
    }

    public Tile GetTile(int row, int column)
    {
        if (IsInMap(row, column)) return _tiles[column][row];
        return null;
    }

    public bool CanOccupy(int row, int column)
    {
        return IsInMap(row, column) && _tiles[column][row].CanBeOccupied();
    }

    public bool IsOccupied(int row, int column)
    {
        return IsInMap(row, column) && _tiles[column][row].IsOccupied();
    }

    public bool PlaceOnMap(Character occupant)
    {
        int row = occupant.GetPosition().X, column = occupant.GetPosition().Y;

        if (CanOccupy(row, column))
        {
            _tiles[column][row].PlaceOnTile(occupant);
            return true;
        }

        return false;
    }

    public bool PlaceOnMap(Item item)
    {
        int row = item.GetPosition().X, column = item.GetPosition().Y;

        if (CanOccupy(row, column))
        {
            _tiles[column][row].PlaceOnTile(item);
            return true;
        }

        return false;
    }
}