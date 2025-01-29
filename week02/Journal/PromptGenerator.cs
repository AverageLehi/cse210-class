public class PromptGenerator
{
    // Add properties and methods for the Prompt class here
    private List<string> prompts = new List<string>
    {
        "What was the best part of your day?",
        "What are you grateful for today?",
        "What made you smile today?",
        "What is one thing you learned today?",
        "What is one thing you want to accomplish tomorrow?",
        "What was the most challenging part of your day?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}