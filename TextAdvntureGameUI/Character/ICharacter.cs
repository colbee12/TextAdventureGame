namespace TextAdvntureGameUI.Character;

public interface ICharacter
{
    public string Name { get; set; }
    public int AttackDamage { get; set; }
    public int Health { get; set; }
    int Gold { get; set; }
    List<Item> Inventory { get; set; }
    
    public int Attack();
    public void TakeDamage(int damage);
    
   
    
    
    
}