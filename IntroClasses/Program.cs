namespace IntroClasses;

public class Program
{
    public static void Main()
    {
        bool isPlaying = true;
        Player hero = new Player(3, 4);
        Player hero2 = new Player(1, 2);
        hero.Display();
        while (isPlaying)
        {
            isPlaying = hero.TakeTurn();
            isPlaying = hero2.TakeTurn();
        }

        Console.WriteLine("Goodbye!");
    }
}