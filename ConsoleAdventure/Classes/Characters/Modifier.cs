namespace ConsoleAdventure;

public class Modifier
{
    public float DamageMultiplier { get; set; } = 1.0f;
    public int NumberOfHits { get; set; } = 1;
    public bool AreaOfEffect { get; set; } = false;
    public bool DamageNegation { get; set; } = false;
    public float DamageReductionPercent { get; set; } = 0.0f;
    public bool AppliesBurn { get; set; } = false;
    public float ChanceToStealItem { get; set; } = 0.0f;
}