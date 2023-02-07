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
        foreach(char letter in _text){
            _text.Replace(letter, '_');
        }
        return _text;
    }
    else{
        return _text;
    }        
}
}