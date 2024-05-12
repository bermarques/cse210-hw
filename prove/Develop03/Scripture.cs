class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        foreach (string _word in text.Split(' '))
        {
            _words.Add(new Word(_word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        int hideAttempt = 0;
        do
        {
            int randomNumber = random.Next(0, _words.Count);
            if (!_words[randomNumber].IsHidden())
            {
                _words[randomNumber].Hide();
                hideAttempt++;
            }
        } while (hideAttempt < numberToHide);
    }

    public string GetDisplayText()
    {
        List<string> text = new List<string>();
        foreach (var word in _words)
        {
            text.Add(word.GetDisplayText());
        }
        return $"{_reference.GetDisplayText()} {string.Join(" ", text)}";
    }

    public bool IsCompletelyHidden()
    {
        bool isAllHidden = true;
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                isAllHidden = false;
            }
        }
        return isAllHidden;
    }
}