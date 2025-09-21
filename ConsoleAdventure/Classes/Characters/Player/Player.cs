namespace ConsoleAdventure.Classes.Characters.Player;

public class Player : Character
{
    public Player(string name, string role, int health, int attack, int defense) : base(role, health, attack, defense)
    {
        Name = name;
    }

    public void AdventureTime()
    {
        Random random = new Random();

        
    }

    public void Rest()
    {

        Console.WriteLine("You rest for a while to regain any lost health...");
        Health += 25;
    }
}