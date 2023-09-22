using System;
using System.Collections.Generic;
using System.IO;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    public string _prompt1 = "What was the most exciting thing that happened to you today?";
    public string _prompt2 = "What did you eat for breakfast this morning?";
    public string _prompt3 = "What am I most grateful for today?";
    public string _prompt4 = "If you were playing Mario Kart and your friend hit you with a blue shell, how would you exact your revenge?";
    public string _prompt5 = "What was the most interesting thing you did today?";
    public string _prompt6 = "Why did Mr. Rochester lock his wife up in the attic in Jane Eyre?";
    public string _prompt7 = "What is the craziest thing you've ever said to someone shorter than you?";
    public string _prompt8 = "Are you wearing matching socks today?";
    public string _prompt9 = "Write about your day.";
    public string _prompt10 = "Who was the most interesting person I interacted with today?";
    public string _prompt11 = "What was the best part of my day?";
    public string _prompt12 = "How did I see the hand of the Lord in my life today?";
    
    public void AddPrompts()
    {
        _prompts.Add(_prompt1);
        _prompts.Add(_prompt2);
        _prompts.Add(_prompt3);
        _prompts.Add(_prompt4);
        _prompts.Add(_prompt5);
        _prompts.Add(_prompt6);
        _prompts.Add(_prompt7);
        _prompts.Add(_prompt8);
        _prompts.Add(_prompt9);
        _prompts.Add(_prompt10);
        _prompts.Add(_prompt11);
        _prompts.Add(_prompt12);
    }
    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_prompts.Count);
        string selectedPrompt = _prompts[index];
        return selectedPrompt;
    }
}