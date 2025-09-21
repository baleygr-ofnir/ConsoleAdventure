using ConsoleAdventure.Classes.Characters;
using ConsoleAdventure.Classes.Characters.NonPlayer;
using ConsoleAdventure.Classes.Characters.Player;
using ConsoleAdventure.Classes.Characters.Player.Roles;
namespace ConsoleAdventure.Classes;

public class AdventureGame
{
    private bool running = false;
    Player Player;

    Character[] Enemies =
    [
        new Bandit(),
        new Cultist(),
        new FogWraith(),
        new Skeleton(),
        new Wolf()
    ];

    public AdventureGame()
    {
        string[] menuOptions =
        [
            "Go On Adventure",
            "Rest",
            "Show Player Status",
            "Exit Game"
        ];
        Player = CreateCharacter();

        Player.GetProfile();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey(true);
        while (!running && Player.Health != 0)
        {
            int selectedFunction = SelectionMenu(menuOptions);
            switch (selectedFunction)
            {
                case 0:
                    Player.AdventureTime();
                    break;
            }
        }
    }

    private Player CreateCharacter()
    {
        Player character = null;
        string[] roles = ["Knight", "Mage", "Rogue"];
        Console.Write("Enter name: ");
        string? name = Console.ReadLine();
        Console.Clear();
        string role;
        int selectedIndex = SelectionMenu(roles);

        role = roles[selectedIndex];
        switch (role)
        {
            case "Knight":
                character = new Knight(name);
                break;
            case "Mage":
                character = new Mage(name);
                break;
            case "Rogue":
                character = new Rogue(name);
                break;
        }

        return character;
    }

    private int SelectionMenu(string[] menuOptions)
    {
        ConsoleKeyInfo keyPressed;
        int currentIndex = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("Select role: ");
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