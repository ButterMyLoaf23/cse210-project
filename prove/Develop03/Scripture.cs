using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _random = new Random();
        _words = text.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(words => new Word(words)).ToList();
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string scriptureText = string.Join(" ", _words.Select(words => words.GetDisplayText()));
        return $"{referenceText} {scriptureText}";
    }

    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = _words.Where(words => !words.IsHidden()).ToList();

        if (visibleWords.Count == 0)
        {
            return;
        }

        int countToHide = Math.Min(numberToHide, visibleWords.Count);

        for (int i = 0; i < countToHide; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(words => words.IsHidden());
    }
}

