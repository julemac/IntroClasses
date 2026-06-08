// namespace IntroClasses;
//
// public abstract class GameObject
// {
//     protected Vector2D Position;
//     private string _avatar;
//
//     public GameObject(Map map, int x = 0, int y = 0, string avatar = "!")
//     {
//         Position = new Vector2D(x, y);
//         _avatar = avatar;
//         if(!map.PlaceOnMap(this)) Console.WriteLine("Could not add to map");
//     }
//
//     public void Display()
//     {
//         Console.SetCursorPosition(Position.X, Position.Y);
//         Console.Write(_avatar);
//     }
//
//     public void FixTileRep(Map map, int row, int column)
//     {
//         Console.SetCursorPosition(row, column);
//         //Console.Write(map.GetTileRepresentation(Position.X, Position.Y));
//         map.GetTileRepresentation(row, column);
//         
//     }
//     
//     public Vector2D GetPosition()
//     {
//         return Position;
//     }
//
//     public abstract void Interact();
// }