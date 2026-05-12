using System;
using System.IO; 

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public PromptGenerator _prompter = new PromptGenerator();

    public void AddEntry()
    {
        string prompt = _prompter.GetPrompt();

        Console.WriteLine(prompt);
        string answer = Console.ReadLine();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        Entry entry = new Entry(dateText, prompt, answer);
        _entries.Add(entry);
    }
    public void DisplayEntries()
    {
        for (int i = 0; i < _entries.Count; i++)
        {
            _entries[i].DisplayEntry();
        }
    }
    public void SaveJournal()
    {

        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            for (int i = 0; i < _entries.Count; i++)
            {
                outputFile.WriteLine($"{_entries[i]._date}|{_entries[i]._prompt}|{_entries[i]._response}");
            }
        }
    }
    public void LoadJournal()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];
            Entry entry = new Entry(date, prompt, response);
            _entries.Add(entry);
        }
    }
}