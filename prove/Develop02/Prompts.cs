using System;
using System.Collections.Generic;

public class Prompts
{
    public List<string> PromptList { get; private set; }

    public Prompts()
    {
        PromptList = new List<string>
        {
            "What was the best part of my day?",
            "If I had one thing I could do over today, what would it be?",
            "What am I most grateful for today?",
            "What did I learn today?",
            "What was one new idea that I came up with today?"
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(PromptList.Count);
        return PromptList[index];
    }
}
