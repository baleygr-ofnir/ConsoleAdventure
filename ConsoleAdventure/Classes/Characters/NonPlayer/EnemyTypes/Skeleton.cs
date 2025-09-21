namespace ConsoleAdventure.Classes.Characters.NonPlayer.EnemyTypes;

public class Skeleton : NonPlayer
{
    public Skeleton() : base("Skeleton", 40, 10, 8)
    {
        DamageModifier = new Modifier(damageReductionPercent: 0.5f);
    }
}