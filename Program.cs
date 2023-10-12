internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }
    static void Menu()
    {
        Console.WriteLine("1 - New game");
        Console.WriteLine("2 - Load game");
        Console.WriteLine("3 - Rules");
        Console.WriteLine("4 - Authors");
        Console.WriteLine("0 - Exit");
        int ans = Convert.ToInt32(Console.ReadLine());
        for(int i = ans; i <= 4; i++)
        {
            Check(i);
        }
    }
    static void Check(int n)
    {
        Message mes;
        if (n== 1)
        {
            mes = NewGame;
        }
        else if (n == 2)
        {
            mes = LoadGame;
        }
        else if (n == 3)
        {
            mes = Rules;
        }
        else if (n == 4)
        {
            mes = Authors;
        }
        else if (n == 0)
        {
            mes = Exit;
        }
        else mes = Exit;
        mes();
    }
    static void NewGame()
    {
        Console.WriteLine("Starting new game...");
    }
    static void LoadGame()
    {
        Console.WriteLine("Loading a save...");
    }
    static void Rules()
    {
        Console.WriteLine("Don't be toxic and show respect to other players!");
    }
    static void Authors()
    {
        Console.WriteLine("The one and the only: Alex Untilov");
    }
    static void Exit()
    {
        Console.WriteLine("Bye...");
    }
    delegate void Message();
}

