//Encapsulates individual word behavior, including hiding and displaying words.

class Word
{
    private string text;
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        this.text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public string GetDisplayWord()
    {
        return IsHidden ? "_____" : text;
    }
}
