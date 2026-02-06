namespace TextAdvntureGameUI.GameFunctions;

public static class UserInteraction
{
    public static void GameDialogue(string text)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(text);    
        Console.ResetColor();
    }

    public static string GetUserInput(string prompt)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(prompt);
        Console.ForegroundColor = ConsoleColor.Blue;
        return Console.ReadLine();
    }

    public static void DeathScreen(String text)
    {
        Console .ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(text);
        Thread.Sleep(3000);
        Environment.Exit(0);
    }

    public static void PlayerInquiry(string[] questions, string[] answers)
    {
        var ValidChoice = false;
        var PlayerChoice = string.Empty;

        while (!ValidChoice)
        {
            var questionPrompt = "";

            for (int i = 0; i < questions.Length; i++)
            {
                questionPrompt += $"{i + 1}. {questions[i]}\n";
            }

            PlayerChoice = GetUserInput(questionPrompt);
            int choiceIndex;
            
            while (!int.TryParse(PlayerChoice, out choiceIndex))
            {
                GameDialogue($"I Dont understand. Please try again.");
                PlayerChoice =  GetUserInput(questionPrompt);
            }

            if (choiceIndex >= questions.Length)
            {
                GameDialogue($"Goodbye.... Brave Knight!");
                return;
            }
            else if (choiceIndex >= 1 && choiceIndex <= questions.Length)
            {
                GameDialogue(answers[choiceIndex - 1]);
            }
            else
            {
                GameDialogue("Sorry, I don't understand.");
            }
            
            
            
            
        }

        
    }
    
    
    
    
    
    
}