using System;
using System.Collections.Generic;
using System.IO;

class Journal {
    public List<Entry> entries = new List<Entry>();
    public void AddEntry(string prompt, string response, string date){
        Entry entry = new Entry(prompt, response, date);
        entries.Add(entry);
        } 
    public void Display(){
        foreach (Entry entry in entries){
            Console.WriteLine("Prompt: " + entry._entryPrompt);
            Console.WriteLine("Response: " + entry._entryData);
            Console.WriteLine("Date: " + entry._entryDate);
            Console.WriteLine();
            }
    } 
    public void Save(string filename){
        StreamWriter writer = new StreamWriter(filename);
        foreach (Entry entry in entries){
        writer.WriteLine(entry._entryPrompt);
        writer.WriteLine(entry._entryData);
        writer.WriteLine(entry._entryDate);
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
        AddEntry(prompt, response, date);
    }
}}