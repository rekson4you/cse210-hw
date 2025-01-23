using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numWordsToHide)
    {
        Random random = new Random();
        var wordsToHide = _words.Where(word => !word.IsHidden())
                               .OrderBy(_ => random.Next())
                               .Take(numWordsToHide)
                               .ToList();

        foreach (var word in wordsToHide)
        {
            word.Hide();
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference.GetDisplayText()}\n{scriptureText}";
    }

    public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
