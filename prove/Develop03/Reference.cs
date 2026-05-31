using System;


public class Reference
{
    private string _book = "";
    private string _chapterAndVerse = "";

    public Reference(string book, string chapterAndVerse)
    {
        _book = book;
        _chapterAndVerse = chapterAndVerse;
    }

    public string GetDisplayString()
    {
        string reference = $"{_book} {_chapterAndVerse}";
        return reference;
    }
}