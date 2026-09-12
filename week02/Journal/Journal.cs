using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{

    public List<Entry> _entries = new List<Entry>();
    Entry entry = new Entry();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        int totalDaysWritten = 1;
        string firstCheck = "yes";
        string previousDate = "";
        foreach (Entry entry in _entries)
        {


            string currentDate = entry._date;
            if (firstCheck == "yes" && currentDate != previousDate)
            {
                firstCheck = "no";
                previousDate = entry._date;
            }
            else if (currentDate == previousDate)
            {
            }
            else if (currentDate != previousDate)
            {
                previousDate = currentDate;
                totalDaysWritten += 1;
            }
            entry.Display();
            Console.WriteLine("");
        }
        Console.WriteLine($"Congratulations, You have written for {totalDaysWritten} Total Days!");

    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {

            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}//{entry._promptText}//{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            Entry loadedEntries = new Entry();
            string[] parts = line.Split("//");

            loadedEntries._date = parts[0];
            loadedEntries._promptText = parts[1];
            loadedEntries._entryText = parts[2];

            _entries.Add(loadedEntries);
        }
    }


}