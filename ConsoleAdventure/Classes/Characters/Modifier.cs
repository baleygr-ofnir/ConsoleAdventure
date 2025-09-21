namespace ConsoleAdventure;

public record Modifier
{
    public float DamageMultiplier { get; set; }
    public int NumberOfHits { get; set; }
    public bool ApplyBurn { get; set; }
    public float DamageReductionPercent;
    
    public Modifier
    (
       float damageMultiplier = 1.0f,
       int numberOfHits = 1,
       float damageReductionPercent = 0.0f
    )
    {
        DamageMultiplier = damageMultiplier;
        NumberOfHits = numberOfHits;
        DamageReductionPercent = damageReductionPercent;
    }
}