namespace ConsoleAdventure.Classes.Characters.NonPlayer;

public class Skeleton : Character
{
    public Skeleton() : base("Skeleton", 40, 10, 8)
    {
        DamageModifier = new Modifier(damageReductionPercent: 0.5f);
    }
}