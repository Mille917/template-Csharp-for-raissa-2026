public class Entry
{
    //Member variables (propreties).
    public string Date { get; set; }
    public string PromptText { get; set; }
    public string EntryText { get; set; }

    //A method to display the entry nicely to the screen
    public void Display()
    {
        System.Console.WriteLine($"Date: {Date} - Prompt: {PromptText}");
        System.Console.WriteLine($"{EntryText}\n");
    }
}