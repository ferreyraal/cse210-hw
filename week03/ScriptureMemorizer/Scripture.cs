public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }


    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";

        foreach (var word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }

        return displayText.Trim(); 
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int wordsHidden = 0;
        // Search for random words that are not hidden 
        while (wordsHidden < numberToHide)
        {
            int index = rand.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                wordsHidden++;
            }
            if (IsCompletelyHidden())
                // When all words are hidden, quit (to prevent searching for words when no more are hidden)
                {
                    break;
                }
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden()) 
            {
                return false;
            }
        }
        return true; 
    }


}