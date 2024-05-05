using System.IO;
using System;
using System.Text;
using System.Diagnostics.SymbolStore;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public string _file;


    public void AddEntry (Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll ()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(List<Entry> entries)
    {
        using StreamWriter outputFile = new (_file);
        foreach (Entry entry in entries)
        {
            outputFile.WriteLine ($"{entry._date},{entry._promptText},{entry._entryText}");
        }
    }
    
    public void LoadFromFile (string file)
    {
        string [] lines = System.IO.File.ReadAllLines(_file);
        foreach (string line in lines)
        {
            string [] parts = line.Split(",");
            Entry entry = new()
            {
                _date=parts[0],
                _promptText = parts[1],
                _entryText = parts[2]
            };
            _entries.Add(entry);
        }
    }
}