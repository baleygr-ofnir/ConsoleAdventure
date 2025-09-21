namespace ConsoleAdventure.Classes.Characters.Player.Roles;

public class Rogue : Player
{
    public Rogue(string name) : base(name,"Rogue", 70, 18, 5)
    {
        DamageModifier = new Modifier(damageMultiplier: 1.2f, numberOfHits: 2);
    }
    
}