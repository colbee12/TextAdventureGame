namespace TextAdvntureGameUI.Character;
//using TextAdvntureGameUI.Items;

public class Knight : CharacterBase
{
    public int Gold { get; set; }
    public List<Item> Inventory { get; set; } = new();

    public void AddItem(Item item)
    {
        Inventory.Add(item);
    }

    public void ShowInventory()
    {
        if (Inventory.Count == 0)
        { 
            Console.WriteLine("Inventory is empty");
            return;
        }
        else
        {
            Console.WriteLine("Your Inventory");
            for (int i = 0; i < Inventory.Count; i++)
            {
                Console.WriteLine($"{i +1}. {Inventory[i]}");
            }
        }
    }
    
    public void UseItem(int index)
    {
        if (index < 0 && index >= Inventory.Count)
        {
            Console.WriteLine("Invalid item selected");
            return;
        }
        
        var item = Inventory[index];
        
        if (item.HealAmount > 0)
        {
            Health += item.HealAmount;
            Console.WriteLine($"You used {item.Name} And Healed {item.HealAmount}");
        }

        if (item.AttackBonus > 0)
        {
            AttackDamage += item.AttackBonus;
            Console.WriteLine($"You Equipped {item.Name} +{item.AttackBonus} Attack");
        }
        Inventory.RemoveAt(index);
        
    }

  
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
  

}