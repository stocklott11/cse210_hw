using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(string prompt, string response)
    {
        entries.Add(new Entry(prompt, response));
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine(entry);
            }
        }
        Console.WriteLine("Journal saved to " + filename);
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            entries.Clear();

            string[] lines = File.ReadAllLines(filename);
            for (int i = 0; i < lines.Length; i += 3)
            {
                string dateLine = lines[i];
                string promptLine = lines[i + 1];
                string responseLine = lines[i + 2];

                string datePart = dateLine.Split("–")[0].Replace("Date:", "").Trim();
                DateTime date = DateTime.Parse(datePart);

                string prompt = promptLine.Replace("Prompt:", "").Trim();
                string response = responseLine.Trim();

                Entry entry = new Entry(prompt, response) { Date = date };
                entries.Add(entry);
            }

            Console.WriteLine("Journal loaded from " + filename);
            DisplayEntries(); // Display entries immediately after loading
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
