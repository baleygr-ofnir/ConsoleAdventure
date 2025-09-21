namespace ConsoleAdventure.Classes.Characters.NonPlayer;

public class Wolf : Character
{
    public Wolf() : base("Wolf", 30, 8, 3)
    {
        DamageModifier = new Modifier(damageMultiplier: 0.7f, numberOfHits: 2);
    }
}