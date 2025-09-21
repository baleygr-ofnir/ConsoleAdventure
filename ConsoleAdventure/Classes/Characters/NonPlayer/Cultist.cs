namespace ConsoleAdventure.Classes.Characters.NonPlayer;

public class Cultist : Character
{
    public Cultist() : base("Cultist", 60, 15, 4)
    {
        DamageModifier = new Modifier(damageMultiplier: 1.3f);
    }
}