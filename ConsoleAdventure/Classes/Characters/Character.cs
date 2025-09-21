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
                _health += value;
            }
        }
    }
    public int Attack;
    public int Defense;
    public bool Burning = false;
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
    
    void TakeDamage()
    {
        int damageTaken = Health - CalculateDamage();
        Health -= damageTaken;
        Console.WriteLine($"{Role} loses {damageTaken} in health and is now at {Health}");
    }

    int CalculateDamage()
    {
        double randomMultiplier = new Random().NextDouble();
        double damageCalc = (randomMultiplier * Health); 
        int damage = damageCalc > 1 ? (int) Math.Floor(randomMultiplier * (Attack * DamageModifier.DamageMultiplier * DamageModifier.NumberOfHits)) : 1;
        return damage;
    }

    void PerformAttack(Character target)
    {
        Console.WriteLine($"{Role} attacks {target.Role} with {DamageModifier.NumberOfHits} hit(s).");
        target.TakeDamage();
        if (DamageModifier.ApplyBurn) target.Burning = true;
    }
    public void GetProfile()
    {
        Console.WriteLine($"---\nNAME: {Name}\nROLE: {Role}\nHEALTH: {Health}\nATTACK: {Attack}\nDEFENSE: {Defense}\n---");
    }
}