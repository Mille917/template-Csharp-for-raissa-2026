// COMMENT CLASS
public class Comment
{
    public string _authorName;
    public string _text;

    public void Display()
    {
        Console.WriteLine($" -{_authorName}: {_text}");
    }
}

