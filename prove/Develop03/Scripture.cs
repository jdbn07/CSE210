using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new();
    private Random rng = new();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] wordAry = text.Split(" ");
        foreach (string wordStr in wordAry)
        {
            _words.Add(new Word(wordStr));
        }
    }

    public void HideRandomWords(int numbersToHide)
    {
        for(int i = 0; i < numbersToHide; i++)
        {
            int index;
            do
            {
                index = rng.Next(_words.Count);
            }
            while (_words[index].IsHidden());

            _words[index].Hide();
            if (IsCompletelyHidden())
                break;
        }
    }

    public string GetDisplayText()
    {
        string output = "";
        output += _reference.GetDisplayText() + " - ";
        foreach (Word word in _words) 
        {
            output += word.GetDisplayText() + " ";
        }
        return output;
    }

    public bool IsCompletelyHidden()
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
}