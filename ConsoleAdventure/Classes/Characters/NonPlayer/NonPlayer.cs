namespace ConsoleAdventure.Classes.Characters.NonPlayer;

public class NonPlayer : Character
{
    public int GoldReward;
    public NonPlayer(string role, int health, int attack, int defense) : base(role, health, attack, defense)
    {
        GoldReward = health * 2;
    }
    
}