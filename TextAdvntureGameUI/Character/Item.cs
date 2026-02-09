namespace TextAdvntureGameUI.Character;

public class Item
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int HealAmount { get; set; }
    public int AttackBonus {get; set;}

    public Item(string name, string description, int healAmount = 0, int attackBonus = 0)
    {
        Name = name;
        Description = description;
        HealAmount = healAmount;
        AttackBonus = attackBonus;
    }

    public override string ToString()
    {
        return $"{Name}: {Description}";
    }

}