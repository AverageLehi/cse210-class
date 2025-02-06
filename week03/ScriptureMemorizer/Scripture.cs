public class Scripture
{
    public ScriptureReference Reference { get; private set; }
    private List<Word> Words;

    public Scripture(ScriptureReference reference, string text)
    {
        Reference = reference;
        Words = text.Split().Select(word => new Word(word)).ToList();
    }

    public bool HideRandomWords(int count)
    {
        Random rnd = new Random();
        var visibleWords = Words.Where(word => !word.IsHidden).ToList();

        if (visibleWords.Count == 0)
        {
            return false;
        }

        int hiddenCount = 0;
        while (hiddenCount < count && visibleWords.Count > 0)
        {
            int index = rnd.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
            hiddenCount++;
        }

        return true;
    }

    public override string ToString()
    {
        return $"{Reference}:\n{string.Join(" ", Words)}";
    }
}
