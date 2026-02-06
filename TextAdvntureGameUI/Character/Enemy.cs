namespace TextAdvntureGameUI.Character;

public class Enemy : ICharacter
{
    public string Name { get; set; }
    public int AttackDamage { get; set; }
    public int Health { get; set; }
    
    
    public int Attack()
    {
        return AttackDamage;
    }
    
    // if we subtract damage from health and its less than or is at 0 we set the health to zero
    public void TakeDamage(int damage)
    {
        if (Health - damage <= 0)
        {
            Health = 0;
        }
        //else if health is not below zero we take heath subtract from it from damage and assign our new health
        else 
        {
            Health -= damage;
        }
    }    
}