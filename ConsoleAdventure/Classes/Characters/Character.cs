namespace ConsoleAdventure;

public class Character
{
    public Character(string name, int health, int attack, int defense)
    {
        Name = name;
        Health = health;
        Defense = defense;
        Attack = attack;
    }

    string Name { get; set; }
    int Health { get; set; }
    int Defense { get; set; }
    int Attack  { get; set; }
    bool Burning { get; set; }
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
    
    void PerformAttack(Character character) {}
    
    void ApplyStatusEffects (Character character) {}
}