namespace ConsoleAdventure.Classes.Characters.Player.Roles;

public class Mage : Player
{
    public Mage(string name) : base(name,"Mage", 60,12,3)
    {
        DamageModifier = new Modifier(applyBurn: true);
    }
}