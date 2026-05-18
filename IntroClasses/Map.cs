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

    // public void showMap()
    // {
    //     foreach (Tile[] tileLine in _tiles)
    //     {
    //         foreach (Tile tile in tileLine)
    //             tile.Display();
    //         
    //         Console.WriteLine();
    //     }
    // }
    //
    // public void placeOccupant(Character occupant, int x, int y){
    //     if (y >= 0 && y < _tiles.Length && x >= 0 && x < _tiles[y].Length && !_tiles[y][x].IsOccupied())
    //     {
    //         _tiles[y][x].Occupy(occupant);
    //     }
    // }
    //
    // public void placeOccupant(Character occupant, Vector2D position)
    // {
    //     placeOccupant(occupant, position.X, position.Y);
    // }
    //
    // public void placeOccupant(Character occupant)
    // {
    //     placeOccupant(occupant,occupant.GetPosition());
    // }
}