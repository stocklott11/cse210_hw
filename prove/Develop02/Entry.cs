public class Entry
{
    public DateTime Date { get; set; } // Made settable to allow loading from file
    public string Prompt { get; private set; }
    public string Response { get; private set; }

    public Entry(string prompt, string response)
    {
        Date = DateTime.Now;
        Prompt = prompt;
        Response = response;
    }

    public override string ToString()
    {
        return $"Date: {Date.ToShortDateString()} – Prompt: {Prompt}\n{Response}\n";
    }
}
