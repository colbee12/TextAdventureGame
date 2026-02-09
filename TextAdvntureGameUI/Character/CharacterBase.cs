namespace TextAdvntureGameUI.Character;

public class CharacterBase : ICharacter
{
    public string Name { get; set; }
    public int AttackDamage { get; set; }
    public int Health { get; set; }
    public int Gold { get; set; }

    public List<Item> Inventory { get; set; } = new();
    
    public int Attack() => AttackDamage;
   
    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health < 0)
        {
            Health = 0;
        }
       
    }
    public bool IsAlive() => Health > 0;
}