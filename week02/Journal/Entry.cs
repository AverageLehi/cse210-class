public class Entry
{
    public DateTime _date;
    public string _promptText;
    public string _entryText;
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine("");
    }
    public override string ToString()
{
    return $"{_date:yyyy-MM-dd HH:mm:ss},{_promptText},{_entryText}";
}
}