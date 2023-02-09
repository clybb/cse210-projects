using System;
class Scripture{

    private Reference _ref;
    private List<Word> _word = new List<Word>();

    public Scripture(Reference reff,  string text){
        _ref = reff;
        string[] words = text.Split(' ');
        foreach(string word in words){
            _word.Add(new Word(word));
        }
    }
    public void HideWords(int count){
        for (int i=0; i<count; i++){
            Random random = new Random();
            int randomNmber = random.Next(0, _word.Count());
            var word = _word[randomNmber];
            word.Hide();
        }
    }
    public Boolean IsCompletlyHidden(){
        return false;
    }
    public void Display(){
        Console.Clear();//clear console
        while (IsCompletlyHidden() != true){
        string sentance = null;//create empty sentance variable
        var reff = _ref.GetDisplay();
        foreach(Word word in _word){
            string text = word.GetDisplay();//get the actual text from the word list
            sentance = sentance + " " + text;//concat all text into into one string
        }
        Console.WriteLine($"{reff} {sentance}");
        Console.WriteLine($"\nPress enter to continue or type 'quit' to finish");
        string exit = Console.ReadLine();
        if (exit == "quit"){
            break;
        }
        else{
            HideWords(3);
        }
        }
    }
}