using TextAdvntureGameUI.Character;

namespace TextAdvntureGameUI.GameFunctions;

public static class Combat
{
    public static void KnightVsOneEnemy(Knight knight, Enemy enemy)
    {
        while (knight.IsAlive() && enemy.IsAlive())
        {
            UserInteraction.GameDialogue($"\n{knight.Name} (Health: {knight.Health} Attack: {knight.AttackDamage}) \nvs\n {enemy.Name}) (Health: {enemy.Health}  Attack: {enemy.AttackDamage})");
            Thread.Sleep(1000);
            
            UserInteraction.GameDialogue($"{knight.Name} attacks {enemy.Name}! ");
            enemy.TakeDamage(knight.Attack());
            Thread.Sleep(1000);

            if (!enemy.IsAlive())
            {
                UserInteraction.GameDialogue($"{enemy.Name} has been killed!");
                Thread.Sleep(1000);
                break;
            }
               
            UserInteraction.GameDialogue($"{enemy.Name} Attacks {knight.Name}!");
            knight.TakeDamage(enemy.Attack());
            Thread.Sleep(1000);
            
            if (!knight.IsAlive())
            {
                UserInteraction.GameDialogue($"{knight.Name} has been killed!");
                Thread.Sleep(1000);
                break;
            }
            
            
        }
        
        
        if (!enemy.IsAlive())
        {
            var goldLooted = enemy.Gold;
            var itemsLooted = enemy.Inventory.Count;

            knight.Inventory.AddRange(enemy.Inventory);
            knight.Gold += enemy.Gold;

            enemy.Inventory.Clear();
            enemy.Gold = 0;

            UserInteraction.GameDialogue($"{knight.Name} looted {goldLooted} gold and {itemsLooted} item(s)!"
            );
        }

       // if (!enemy.IsAlive())
       // {
          //  UserInteraction.GameDialogue($"{knight.Name} loots {enemy.Name}!");
          //  knight.Inventory.AddRange(enemy.Inventory);
          //  knight.Gold += enemy.Gold;
           // enemy.Inventory.Clear();
          //  enemy.Gold = 0;
      // }
    }
}