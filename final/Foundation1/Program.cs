using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        List<Video> videoList = new List<Video>();
        //video 1
        Video video1 = new Video();
        video1.SetTitle();
        video1.SetAuthor();
        video1.SetLength();
        videoList.Add(video1);
        //4 comments
        Comment comment13 = new Comment();
        comment13.SetPerson();
        comment13.SetText();
        video1.AddComment(comment13);
        Comment comment14 = new Comment();
        comment14.SetPerson();
        comment14.SetText();
        video1.AddComment(comment14);
        Comment comment15 = new Comment();
        comment15.SetPerson();
        comment15.SetText();
        video1.AddComment(comment15);
        Comment comment16 = new Comment();
        comment16.SetPerson();
        comment16.SetText();
        video1.AddComment(comment16);

        //video 2
        Video video2 = new Video();
        video1.SetTitle();
        video1.SetAuthor();
        video1.SetLength();
        videoList.Add(video2);
        //4 comments
        Comment comment1 = new Comment();
        comment1.SetPerson();
        comment1.SetText();
        video2.AddComment(comment1);
        Comment comment2 = new Comment();
        comment2.SetPerson();
        comment2.SetText();
        video2.AddComment(comment2);
        Comment comment3 = new Comment();
        comment3.SetPerson();
        comment3.SetText();
        video2.AddComment(comment3);
        Comment comment4 = new Comment();
        comment4.SetPerson();
        comment4.SetText();
        video2.AddComment(comment4);

        //video 3
        Video video3 = new Video();
        video1.SetTitle();
        video1.SetAuthor();
        video1.SetLength();
        videoList.Add(video3);
        //3 comments
        Comment comment5 = new Comment();
        comment5.SetPerson();
        comment5.SetText();
        video3.AddComment(comment5);
        Comment comment6 = new Comment();
        comment6.SetPerson();
        comment6.SetText();
        video3.AddComment(comment6);
        Comment comment7 = new Comment();
        comment7.SetPerson();
        comment7.SetText();
        video3.AddComment(comment7);

        //video 4
        Video video4 = new Video();
        video1.SetTitle();
        video1.SetAuthor();
        video1.SetLength();
        videoList.Add(video4);
        //4 comments
        Comment comment9 = new Comment();
        comment9.SetPerson();
        comment9.SetText();
        video4.AddComment(comment9);
        Comment comment10 = new Comment();
        comment10.SetPerson();
        comment10.SetText();
        video4.AddComment(comment10);
        Comment comment11 = new Comment();
        comment11.SetPerson();
        comment11.SetText();
        video4.AddComment(comment11);
        Comment comment12 = new Comment();
        comment12.SetPerson();
        comment12.SetText();
        video4.AddComment(comment12);

        Console.Write("\n\n");
        foreach (Video video in videoList)
        {
            Console.WriteLine($"{video.GetTitle()} by {video.GetAuthor()}: {video.GetLength()} seconds");
            Console.WriteLine($"Comments:{video.CommentsAmount()}");
            foreach(Comment comment in video.GetCommentList())
            {
                Console.WriteLine($"{comment.GetPerson()}: {comment.GetText()}");
            }
        }


    }
}