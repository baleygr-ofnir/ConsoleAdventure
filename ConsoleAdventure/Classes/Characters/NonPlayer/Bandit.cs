namespace ConsoleAdventure.Classes.Characters.NonPlayer;

public class Bandit : Character
{
    public Bandit() : base("Bandit", 50, 12, 5)
    {
        DamageModifier = new Modifier(damageMultiplier: 0.7f, numberOfHits: 2);
    }
}