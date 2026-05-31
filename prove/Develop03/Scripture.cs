using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


public class Scripture
{
    private List<Word> _words;
    private Reference _reference;

    public Scripture()
    {
        _words = new List<Word>();
        string[] lines = System.IO.File.ReadAllLines("./scripture.txt");

        bool isReferenceFound = false;
        foreach (string line in lines)
        {            
            string[] parts = line.Split(" ");

            if (isReferenceFound == false)
            {
                _reference = new Reference(parts[0], parts[1]);
                isReferenceFound = true;
            }
            else
            {
                foreach (string part in parts)
                {
                    Word word = new Word(part);
                    _words.Add(word);
                }
            }
        }    
    }

    public void HideWords()
    {
        int hiddenNumbers = 0;

        while (hiddenNumbers < 3 && AreAllWordsHidden() == false)
        {
            int randomNumber = Random.Shared.Next(0, _words.Count);

            if (!_words[randomNumber].IsHidden())
            {
                _words[randomNumber].Hide();
                hiddenNumbers += 1;
            }
        }   
    }

    public bool AreAllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
    public void Display()
    {
        Console.WriteLine($"{_reference.GetDisplayString()} ");
        foreach (Word word in _words)
        {
            Console.Write(word.GetDisplayString() + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
        
    }
}