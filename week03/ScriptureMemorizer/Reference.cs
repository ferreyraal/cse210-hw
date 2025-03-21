public class Reference
{
    private string _book = "";
    private int _chapter = 0;
    private int _verse = 0;
    private int _endverse = 0;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endverse = 0;
    }
    public Reference(string book, int chapter, int verse, int end_verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endverse = end_verse;
    }

    public string GetDisplayText()
    {
        string reference_text = "";
        if (_endverse == 0)
        {
            reference_text = $"{_book} {_chapter}:{_verse} ";
        }
        else
        {
            reference_text = $"{_book} {_chapter}:{_verse}-{_endverse} ";
        }
        return reference_text;
    }

}