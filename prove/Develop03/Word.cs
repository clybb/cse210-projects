class Word{

private string _text;
private Boolean _isHidden;

public Word(string text){
    _text = text;
}
public void Hide(){
    _isHidden = true;
}
public string GetDisplay(){
    if (_isHidden == true){
        string text = null;
        List<string> letters = new List<string>();
        foreach(char character in _text){
            string letter = character.ToString();
        }
        int count = letters.Count();
        for(int i=0; i<count; i++){
            text = text + "_";
        }
        return text;
    }
    else{
        return _text;
    }        
}
}