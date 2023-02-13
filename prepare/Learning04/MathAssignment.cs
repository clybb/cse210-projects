public class MathAssignment : Assignment{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string textbookSection, string porblems): base(name, topic){
        _textbookSection = textbookSection;
        _problems = porblems;
    }

    public string GetHomeworkList(){
        return $"{_textbookSection} {_problems}";
    }
}