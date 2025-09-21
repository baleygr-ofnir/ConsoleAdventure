namespace ConsoleAdventure.Classes.Characters.NonPlayer.EnemyTypes;

public class Cultist : NonPlayer
{
    public Cultist() : base("Cultist", 60, 15, 4)
    {
        DamageModifier = new Modifier(damageMultiplier: 1.3f);
    }
}