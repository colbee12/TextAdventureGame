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
        
        UserInteraction.GetUserInput($"Hello Sir {knight.Name}, I see your new around here. \n Would you like to ask me something");
        UserInteraction.PlayerInquiry(new string[] { "What is your name?", "What is this place", "Where should I go?" ,"Goodbye"}, new string[] {"I am the commander of this fort. My name is Yargel Flif", "HAHAHA you are in the HIGHLAND the land of the forgotten be careful its quite dangerous..", "If you follow this path it will you to the the great city but be ware of the MONSTERS!!!"});
        Thread.Sleep(3000);
        
        UserInteraction.GameDialogue("you decide to travel down the road in hopes of finding the road \nTraveling...");
        Thread.Sleep(3000);
        UserInteraction.GameDialogue("You sense a strange presence nearby...");
        Thread.Sleep(3000);

        var goblin01 = new Enemy();
        goblin01.Name = "Goblin";
        goblin01.Health = StatGen.GenRandomHealth();
        goblin01.AttackDamage = StatGen.GenRandomEnemyAttack();
        
        Combat.KnightVsOneEnemy(knight, goblin01);
        
        UserInteraction.GameDialogue("YAY YOU WON");






    }
}