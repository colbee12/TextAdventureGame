using TextAdvntureGameUI.Character;

namespace TextAdvntureGameUI.GameFunctions;

public class Game
{
    public static void RunGame()
    {
        UserInteraction.GameDialogue("Welcome to HIGHLANDS! \nLets start by getting your knights name.");
        var knight = new Knight();
        knight.Name = UserInteraction.GetUserInput("What is your name?");
        knight.Health = StatGen.GenRandomHealth();
        knight.AttackDamage = StatGen.GenRandomKnightAttack();
        
        
        UserInteraction.GetUserInput($"Hello Sir {knight.Name}, I see you are new around here. \n Would you like to ask me something");
        UserInteraction.PlayerInquiry(new string[] { "What is your name?", "What is this place", "Where should I go?" ,"Goodbye"}, new string[] {"I am the commander of this fort. My name is Yargel Flif", "HAHAHA you are in the HIGHLAND the land of the forgotten be careful its quite dangerous..", "If you follow this path it will lead you to a great city but be ware of the MONSTERS!!!"});
        Thread.Sleep(3000);
        
        UserInteraction.GameDialogue("you decide to travel down the road in hopes of finding the road \nTraveling...");
        Thread.Sleep(3000);
        UserInteraction.GameDialogue("You sense a strange presence nearby...");
        Thread.Sleep(3000);

        var goblin01 = new Enemy
        {
            Name = "Goblin",
            Health = StatGen.GenRandomHealth(),
            AttackDamage = StatGen.GenRandomEnemyAttack(), 
            Gold = StatGen.GenRandomGold()
        };
    
       goblin01.Inventory.Add(new Item("lesser Health Potion", "Restores 20 HP", healAmount: 20));
      // Console.WriteLine(goblin01.Inventory.Count);
       //Console.WriteLine(goblin01.Gold);

        Combat.KnightVsOneEnemy(knight, goblin01);

        foreach (var item in goblin01.Inventory)
        {
            knight.AddItem(item);
        }
        UserInteraction.GameDialogue($"Yay you defeated {goblin01.Name} And Found {goblin01.Gold} Gold. \nAnd {goblin01.Inventory.Count} items you found.");
        
           
        knight.Gold += goblin01.Gold;
        goblin01.Inventory.Clear();
        goblin01.Gold = 0;

        Console.WriteLine(knight.Inventory);
        UserInteraction.GameDialogue("YAY YOU WON");






    }
}