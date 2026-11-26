using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video v1 = new Video()
        {
            _title = "Morning Desk Setup Tour",
            _author = "TechWithLeo",
            _lengthSeconds = 420
        };
        v1._comments.Add(new Comment { _authorName = "Sarah M.", _text = "Clean monitor arm setup!" });
        v1._comments.Add(new Comment { _authorName = "David K.", _text = "What lamp that on the desk?" });
        v1._comments.Add(new Comment { _authorName = "Nadia P.", _text = "Super relaxing video." });
        videos.Add(v1);

        //Repeat for 2-3 more video objects with 3-4 comments each ...

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}