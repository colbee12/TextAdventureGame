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
        UserInteraction.GameDialogue("You decide to look what you have on you and travel down the road in hopes of finding the City");
        knight.ShowInventory();
        Console.WriteLine($"Gold {knight.Gold}");
        Thread.Sleep(3000);
        UserInteraction.GameDialogue("Traveling...");
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
     
       UserInteraction.GameDialogue("A weak goblin has appered!");
       Thread.Sleep(3000);
       string Choice = UserInteraction.GetUserInput("Do you fight or flee (Yes)/(No)");

       if (Choice.ToLower() == "yes")
       {
           Console.WriteLine("you Decide to fight!!");
           Thread.Sleep(1000);
        Combat.KnightVsOneEnemy(knight, goblin01);
       }
       else
       {
           UserInteraction.GameDialogue("You Flee Like a coward!");
       }
           
       
       

        
       Console.WriteLine();
        knight.ShowInventory();
        Console.WriteLine($"Gold {knight.Gold}");
        UserInteraction.GameDialogue("YAY YOU WON");






    }
}