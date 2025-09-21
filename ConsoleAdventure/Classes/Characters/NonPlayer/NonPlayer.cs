namespace ConsoleAdventure.Classes.Characters.NonPlayer;

public class NonPlayer : Character
{
    public int GoldReward;
    public NonPlayer(string role, int health, int attack, int defense) : base("Fog Wraith", 150, 20, 10)
    {
        GoldReward = health * 2;
    }
    
}