using System;
using System.Collections.Generic;
using System.IO;

class Journal {
    public List<Entry> entries = new List<Entry>();
    public void AddEntry(string prompt, string response, string date, string id){
        Entry entry = new Entry(prompt, response, date, id);
        entries.Add(entry);
        } 
    public void Display(){
        foreach (Entry entry in entries){
            entry.Display(entry._entryPrompt, entry._entryData, entry._entryDate);
            }
    } 
    public void Save(string filename){
        StreamWriter writer = new StreamWriter(filename);
        foreach (Entry entry in entries){
        writer.WriteLine(entry._entryPrompt);
        writer.WriteLine(entry._entryData);
        writer.WriteLine(entry._entryDate);
        writer.WriteLine(entry._entryId);
        }
    writer.Close();
    } 
    public void Load(string filename){
    entries.Clear();
    StreamReader reader = new StreamReader(filename);
    while (!reader.EndOfStream){
        string prompt = reader.ReadLine();
        string response = reader.ReadLine();
        string date = reader.ReadLine();
        string id = reader.ReadLine();
        AddEntry(prompt, response, date, id);
    }
    }
    public void Count(){
        int entryId = 0;
        foreach(Entry entry in entries){
            int id = int.Parse(entry._entryId);
            if (id > entryId){
                entryId = id;
            }
        }
        Console.WriteLine($"You have made a total of {entryId} entries in this journal.");
    }
}