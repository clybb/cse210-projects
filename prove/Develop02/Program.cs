using System;

class Program
{
    static void Main(string[] args)
    {
        Entry entry1 = new Entry();
        entry1._entryId = "1";
        entry1._enrtyPrompt = "hi";
        entry1._entryData = "hiiiii";
        entry1._entryDate = "date";
        Menu menu = new Menu();
        menu.Run();

        entry1.Display(entry1._enrtyPrompt, entry1._entryData, entry1._entryDate);
    }
}