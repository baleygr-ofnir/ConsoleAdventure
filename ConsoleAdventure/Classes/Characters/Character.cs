namespace ConsoleAdventure;

public class Character
{
    public string Name = "Unknown";
    public int Health = 100;
    public int Defense = 50;
    public int Attack = 50;
    public bool Burning = false;

    protected Character(int health, int attack, int defense)
    {
        Health = health;
        Defense = defense;
        Attack = attack;
    }

    Modifier Modifier { get; set; } = new Modifier();

    int TakeDamage(int damage)
    {
        int damageTaken = Health - CalculateDamage();
        return damageTaken;
        
        // if (Burning) -1 dmg
    }

    int CalculateDamage()
    {
        double randomMultiplier = new Random().NextDouble();
        double damageCalc = (randomMultiplier * Health); 
        int damage = damageCalc > 1 ? (int) Math.Floor(randomMultiplier * (Attack * Modifier.DamageMultiplier * Modifier.NumberOfHits)) : 1;
        if (Modifier.DamageReductionPercent > 0)
        {
            float damageReduction = damage - (damage * Modifier.DamageReductionPercent);
            damage = damageReduction > 1 ? (int) Math.Floor(damageReduction) : 1;
        }
        return damage;
    }

    void PerformAttack(Character character)
    {
        
    }

    void ApplyStatusEffects (Character character) {}

    public void Rest()
    {
        Console.WriteLine("You rest for a while and regain any lost health...");
        if 
    }
}