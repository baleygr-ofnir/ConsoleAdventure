namespace ConsoleAdventure.Classes.Characters;

public abstract class Character
{
    public string Name = "Unknown";
    public string Role;
    private readonly int _maxHealth;

    private int _health;
    public int Health
    {
        get => _health;
        set
        {
            if (value > _maxHealth)
            {
                _health = _maxHealth;
            } else if (value < 0)
            {
                _health = 0;
            } else
            {
                _health = value;
            }
        }
    }
    public int Attack;
    public int Defense;
    public Modifier DamageModifier { get; set; }

    public Character(string role, int health, int attack, int defense)
    {
        Role = role;
        _maxHealth = health;
        Health = health;
        Defense = defense;
        Attack = attack;
        DamageModifier = new Modifier();
    }

    private void TakeDamage()
    {
        int damageTaken = CalculateDamage();
        Health -= damageTaken;
        Console.WriteLine($"{Role} loses {damageTaken} in health and is now at {Health}");
    }

    private int CalculateDamage()
    {
        double randomMultiplier = new Random().NextDouble();
        double damageCalc = (randomMultiplier * Health); 
        int damage = damageCalc > 1 ? (int) Math.Floor(randomMultiplier * (Attack * DamageModifier.DamageMultiplier * DamageModifier.NumberOfHits)) : 1;
        if (DamageModifier.DamageReductionPercent > 0.0f)
        {
            damage = (int)Math.Ceiling(damage * (1 - DamageModifier.DamageReductionPercent));
            if (damage < 1) damage = 1; // ensure minimum damage of 1
        }
        return damage;
    }

    public void PerformAttack(Character target)
    {
        Console.WriteLine($"{Role} attacks {target.Role} with {DamageModifier.NumberOfHits} hit(s).");
        target.TakeDamage();
    }

}
