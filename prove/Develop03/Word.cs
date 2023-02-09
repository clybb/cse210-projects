class Word{

private string _text;
private Boolean _isHidden;

public Word(string text){
    _text = text;
}
public void Hide(){
    _isHidden = true;
}
public Boolean isHidden(){
    return _isHidden;
}
public string GetDisplay(){
    if (_isHidden == true){
        string text = null;// create an empty string
        List<string> letters = new List<string>();// create a new list for letters
        foreach(char character in _text){//interate through each letter in _text and add it to the list letters
            string letter = character.ToString();
            letters.Add(letter);
        }
        int count = letters.Count();//count how many letters in letters
        for(int i=0; i<count; i++){//for each letter in letters add an underscore in the string text
            text = text + "_";
        }
        return text;
    }
    else{
        return _text;
    }        
}
}