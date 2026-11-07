public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~|~{entry._promptText}~|~{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        List<Entry> entries = new List<Entry>();

        foreach (string line in File.ReadAllLines(file))
        {
            string[] parts = line.Split("~|~", 3, StringSplitOptions.None);
            if (parts.Length != 3)
            {
                throw new FormatException("The file contains an invalid journal entry.");
            }

            entries.Add(new Entry
            {
                _date = parts[0],
                _promptText = parts[1],
                _entryText = parts[2]
            });
        }

        _entries = entries;
    }
}
