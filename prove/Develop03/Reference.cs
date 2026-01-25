using System;
using System.Collections.Generic;

class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;


    // This will handle my single verses.
    public Reference(string book, int chapter, int verse)
        {
            _book = book;
            _chapter = chapter;
            _startVerse = verse;
            _endVerse = verse;
        }

    // This will handle my mulitple verses
    public Reference(string book, int chapter, int startVerse, int endVerse)
        {
            _book = book;
            _chapter = chapter;
            _startVerse = startVerse;
            _endVerse = endVerse;
        }

    public string GetDisplayText()
        {
        if (_startVerse == _endVerse)
        {
            return $"{_book} {_chapter}: {_startVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }
}