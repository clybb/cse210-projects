using System;

class Entry {
    public string _entryId;
    public string _entryData;
    public string _entryDate;
    public string _enrtyPrompt;

    public void Display(string _entryPrompt, string _entryData, string _entryDate){
        Console.WriteLine($"Date:{_entryDate} - Prompt: {_entryPrompt}");
        Console.WriteLine($"{_entryData}");
    }
}