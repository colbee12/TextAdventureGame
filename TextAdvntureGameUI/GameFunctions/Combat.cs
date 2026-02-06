using TextAdvntureGameUI.Character;

namespace TextAdvntureGameUI.GameFunctions;

public static class Combat
{
    public static void KnightVsOneEnemy(Knight knight, Enemy enemy)
    {
        while (knight.Health > 0 && enemy.Health > 0)
        {
            UserInteraction.GameDialogue($"\n{knight.Name} (Health: {knight.Health} Attack: {knight.AttackDamage}) vs {enemy.Name}) (Health: {enemy.Health} Attack: {enemy.AttackDamage})");
            Thread.Sleep(4000);
            
            UserInteraction.GameDialogue($"{knight.Name} attacks {enemy.Name}! ");
            enemy.TakeDamage(knight.Attack());
            Thread.Sleep(4000);

            if (enemy.Health <= 0)
            {
                UserInteraction.GameDialogue($"{enemy.Name} has been killed!");
                Thread.Sleep(5000);
                break;
            }
            
            UserInteraction.GameDialogue($"{enemy.Name} Attacks {knight.Name}!");
            knight.TakeDamage(enemy.Attack());
            Thread.Sleep(5000);
            
            if (knight.Health <= 0)
            {
                UserInteraction.GameDialogue($"{knight.Name} has been killed!");
                Thread.Sleep(5000);
                break;
            }
            
        }
    }
}