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
            int randomNmber = random.Next(1, 100);
            var word = _word[randomNmber];
            word.Hide();
        }
    }
    public Boolean IsCompletlyHidden(){
        return false;
    }
    public void Display(){
        while (IsCompletlyHidden() != true){
        string sentance = null;
        var reff = _ref.GetDisplay();
        foreach(Word word in _word){
            string text = word.GetDisplay();
            sentance = sentance + " " + text;
        }
        Console.WriteLine($"{reff} {sentance}");
        }
    }
}