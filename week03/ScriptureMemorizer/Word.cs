public class Word
{
    private string _text;
    private bool _isHidden;
    public Word(string text)
    {
        _text = text;
        _isHidden = false; //Starts visible
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            //Return underscores matching the length of the word (e.g., "The" become "_ _ _")
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }

}