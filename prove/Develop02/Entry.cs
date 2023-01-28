using System;

class Entry {
    public string _entryData;
    public string _entryDate;
    public string _entryPrompt;

    public Entry(string prompt, string response, string date){
        _entryData = response;
        _entryPrompt = prompt;
        _entryDate = date;

    }

    public void Display(string _entryPrompt, string _entryData, string _entryDate){
        Console.WriteLine($"Date:{_entryDate} - Prompt: {_entryPrompt}");
        Console.WriteLine($"{_entryData}");
    }
}