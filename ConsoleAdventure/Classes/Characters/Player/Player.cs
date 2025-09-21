namespace ConsoleAdventure.Classes.Characters.Player;

public class Player : Character
{
    public int Gold { get; private set; }

    public Player(string name, string role, int health, int attack, int defense) : base(role, health, attack, defense)
    {
        Name = name;
    }

    public void AdventureTime(NonPlayer.NonPlayer[] enemies)
    {
        Random random = new Random();
        int randomIndex = random.Next(0, enemies.Length);
        NonPlayer.NonPlayer enemy = enemies[randomIndex];
        bool flee = false;
        int heals = 0;
        
        string[] adventureOptions = [
            "Attack",
            "Heal",
            "Flee"
        ];
        do
        { 
            int menuSelection = AdventureGame.SelectionMenu(adventureOptions, $"---In battle with {enemy.Role}---\n{Role} {Name}'s Health: {Health}\nEnemy {enemy.Role}'s Health: {enemy.Health}\n\nSelect adventure action");
            Console.WriteLine($"");
            switch (menuSelection)
            {
                case 0:
                    PerformAttack(enemy);
                    break;
                case 1:
                    if (heals == 3)
                    {
                        Console.WriteLine("You have already performed the max amount of in-battle heals.");
                        break;
                    }
                    Rest();
                    heals++;
                    break;
                case 2:
                    flee = true;
                    break;
            }
            enemy.PerformAttack(this);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        } while (enemy.Health > 0 && Health > 0 && !flee);
        
        if (enemy.Health == 0)
        {
            Gold += enemy.GoldReward;
            Console.WriteLine($"Enemy {enemy.Role} has died and you gained 50 gold.");
            GetStatus();
        }
    }

    public void Rest()
    {
        Console.Clear();
        Console.WriteLine("You rest to regain any lost health...");
        Health += 25;
        Console.WriteLine($"Current health: {Health}");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey(true);
    }
    
    public void GetStatus()
    {
        Console.Clear();
        Console.WriteLine($"---\nNAME: {Name}\nROLE: {Role}\nHEALTH: {Health}\nATTACK: {Attack}\nDEFENSE: {Defense}\nGOLD: {Gold}\n---");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey(true);
    }
    
}