class Journal
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
        string fileName = file;
        Console.WriteLine(fileName);
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine("date,prompt,text");

            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~~{entry._promptText}~~{entry._entryText}");
            }
        }
    }


    public void LoadFromFile(string file)
    {
        string fileName = file;
        string[] lines = File.ReadAllLines(fileName).Skip(1).ToArray();

        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");

            string date = parts[0];
            string prompt = parts[1];
            string text = parts[2];

            _entries.Add(new Entry { _date = date, _entryText = text, _promptText = prompt });
        }

    }
}