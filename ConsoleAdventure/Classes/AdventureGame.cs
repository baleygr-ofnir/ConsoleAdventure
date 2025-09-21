using ConsoleAdventure.Classes.Characters;
using ConsoleAdventure.Classes.Characters.NonPlayer;
using ConsoleAdventure.Classes.Characters.NonPlayer.EnemyTypes;
using ConsoleAdventure.Classes.Characters.Player;
using ConsoleAdventure.Classes.Characters.Player.Roles;
namespace ConsoleAdventure.Classes;

public class AdventureGame
{
    private bool running;
    Player Player;

    NonPlayer[] Enemies =
    [
        new Bandit(),
        new Cultist(),
        new FogWraith(),
        new Skeleton(),
        new Wolf()
    ];

    public AdventureGame()
    {
        running = true;
        string[] menuOptions =
        [
            "Go On Adventure",
            "Rest",
            "Show Player Status",
            "Exit Game"
        ];
        Player = CreateCharacter();

        Player.GetStatus();

        Console.Clear();
        while (running && Player.Health != 0)
        {
            int selectedFunction = SelectionMenu(menuOptions, "Select player action:");
            switch (selectedFunction)
            {
                case 0:
                    Player.AdventureTime(Enemies);
                    break;
                case 1:
                    Player.Rest();
                    break;
                case 2:
                    Player.GetStatus();
                    break;
                case 3:
                    running = false;
                    break;
            }
            Console.Clear();
        }

        Console.WriteLine("Game Over.");
    }

    private Player CreateCharacter()
    {
        Player character = null;
        
        string[] roles = ["Knight", "Rogue"];
        Console.Write("Enter name: ");
        string? name = Console.ReadLine();
        
        string role;
        int selectedIndex = SelectionMenu(roles, "Select a role:");
        role = roles[selectedIndex];
        switch (role)
        {
            case "Knight":
                character = new Knight(name);
                break;
            case "Rogue":
                character = new Rogue(name);
                break;
        }

        return character;
    }

    public static int SelectionMenu(string[] menuOptions, string status)
    {
        ConsoleKeyInfo keyPressed;
        int currentIndex = 0;
        do
        {
            Console.Clear();
            Console.WriteLine($"{status} [Press Enter to Select]:");
            for (int i = 0; i < menuOptions.Length; i++)
            {
                if (i == currentIndex)
                {
                    Console.Write(">");
                }
                else
                {
                    Console.Write(" ");
                }

                Console.WriteLine(menuOptions[i]);
            }

            keyPressed = Console.ReadKey(true);

            switch (keyPressed.Key)
            {
                case ConsoleKey.UpArrow:
                    currentIndex = (currentIndex == 0) ? menuOptions.Length - 1 : currentIndex - 1;
                    break;
                case ConsoleKey.DownArrow:
                    currentIndex = (currentIndex == menuOptions.Length - 1) ? 0 : currentIndex + 1;
                    break;
            }
        } while (keyPressed.Key != ConsoleKey.Enter);
        
        return currentIndex;
    }
}