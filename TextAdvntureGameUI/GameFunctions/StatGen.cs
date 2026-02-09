namespace TextAdvntureGameUI.GameFunctions;

public class StatGen
{
    public static int GenRandomGold()
    {
        return Random.Shared.Next(1, 100);
    }
    public static int GenRandomHealth()
    {
       // var random = new Random();
       // return random.Next(1, 101);
       //
       //easy way
       return Random.Shared.Next(75, 101);
    }

    public static int GenRandomKnightAttack()
    {
        return Random.Shared.Next(20, 35);
    }
    

    public static int GenRandomEnemyAttack()
    {
        return Random.Shared.Next(5, 16);
    }
    
    
    
    
}