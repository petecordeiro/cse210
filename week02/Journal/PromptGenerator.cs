public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What small victory did I have today?",
        "What did I learn from a mistake today?",
        "Who helped me today, and how?",
        "What moment made me smile today?",
        "What did I do today that I want to do again?"
    };

    public string GetRandomPrompt()
    {
        return _prompts[Random.Shared.Next(_prompts.Count)];
    }
}
