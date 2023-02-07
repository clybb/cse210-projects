class Reference{

    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int start){
        _book = book;
        _chapter = chapter;
        _startVerse = start;
        _endVerse = 0;
    }
    public Reference(string book, int chapter, int start, int end){
        _book = book;
        _chapter = chapter;
        _startVerse = start;
        _endVerse = end;
    }
    public string GetDisplay(){
        if (_endVerse == 0){
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else{
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    
    }
}