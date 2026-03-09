using IntroClasses;

public class Program
{
    public static void Main()
    {
        Player hero = new Player();
        hero.Display();
        // Console.ReadKey(true);
        string input = Console.ReadLine()!;
        switch (input)
        {
            case "s":
                hero.Move(0, 1);
                break;
            case "w":
                hero.Move(0, -1);
                break;
            case "a":
                hero.Move(-1, 0);
                break;
            case "d":
                hero.Move(1, 0);
                break;
        }
        hero.Display();
    }
}