namespace IntroClasses;

public class Item:GameObject
{

    public Item(Map map, int x = 0, int y = 0, string avatar = "!"):base(map,x,y,avatar)
    {
        if(!map.PlaceOnMap(this)) Console.WriteLine("Could not add to map");
    }

    public override void Interact(Map map)
    {
    }
}