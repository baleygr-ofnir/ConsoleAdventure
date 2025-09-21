namespace ConsoleAdventure.Classes.Characters.Roles;

public class Player : Character
{
    public string Name;
    protected Player(string name, int health, int attack, int defense) : base(health, attack, defense)
    {
        Name = name;
    }

    public void AdventureTime()
    {
        // enter adventure mode - risk of enemy encounter 
    }
    
}