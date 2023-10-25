using System;
using System.Transactions;

public class Video
{
    string _title;
    string _author;
    int _length;
    private List<Comment> _commentList = new List<Comment>();

    public void AddComment(Comment comment)
    {
        _commentList.Add(comment);
    }
    public List<Comment> GetCommentList()
    {
        return _commentList;
    }

    public int CommentsAmount()
    {
        return _commentList.Count;
    }
    public void SetTitle()
    {
        Console.WriteLine("What is the video title?");
        _title = Console.ReadLine();
    }
    public void SetAuthor()
    {
        Console.WriteLine("What is the video's author?");
        _author = Console.ReadLine();
    }
    public void SetLength()
    {
        Console.WriteLine("What is the video's length (in seconds)?");
        _length = int.Parse(Console.ReadLine());
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public int GetLength()
    {
        return _length;
    }
}