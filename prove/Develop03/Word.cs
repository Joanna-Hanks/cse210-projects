using System;


public class Word
{
    private string _word = "";
    private bool _hidden = false;

    public Word(string word)
    {
        _word = word;

    }

    public void Hide()
    {
        _hidden = true;
    }

    public string GetDisplayString()
    {
        if (_hidden == true)
        {
            return "____";
        }
        else
        {
            return _word;
        }
    }

    public bool IsHidden()
    {
        return _hidden; 
    }

}