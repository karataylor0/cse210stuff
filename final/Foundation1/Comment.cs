using System;

public class Comment
{
    private string _person;
    private string _text;

    public void SetPerson()
    {
        Console.WriteLine("What is the commenter's name?");
        _person = Console.ReadLine();
    }
    public void SetText()
    {
        Console.WriteLine("What does the comment say?");
        _text = Console.ReadLine();
    }
    public string GetPerson()
    {
        return _person;
    }

    public string GetText()
    {
        return _text;
    }
}