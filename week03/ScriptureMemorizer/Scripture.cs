using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference = new Reference("",0,0,0);
    private List<Word> _words = new List<Word>();
    private List<string> _hiddenWords = new List<string>();
    


    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        string[] words = text.Split(" ");

        foreach(string word in words)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rnd = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            int wordNumberToHide = rnd.Next(0, _words.Count);
            if (_words[wordNumberToHide].IsHidden() == true)
            {
                i -= 1;
            }
            else
            {
                Word word = _words[wordNumberToHide];
                string wordForHiddenlist = word.GetDisplayText();
                int hiddenWordLength = wordForHiddenlist.Length;

                if (hiddenWordLength > 4)
                {
                    _hiddenWords.Add(wordForHiddenlist);
                }
                else
                {
                }
                _words[wordNumberToHide].Hide();
            }

        }
    }
    
    public void ShowHiddenWords()
    {

        if (_hiddenWords.Count() == 0)
        {
            Console.WriteLine("Sorry, there are no words to show, press Enter to hide some words.");
        }
        else
        {
            foreach (string word in _hiddenWords)
            {
                Console.WriteLine(word);
            }
        }
    }
    public string GetDisplayText()
    {
        string refText = _reference.GetDisplayText();
        string verseText = "";
        foreach (Word word in _words)
        {
            verseText += word.GetDisplayText();
            verseText += " ";
        }

        string fullText = refText + verseText;
        return fullText;
    }

    public bool IsCompletelyHidden()
    {
        bool hiddenCheck = true;
        foreach (Word word in _words)
        {
            hiddenCheck = word.IsHidden();

            if (hiddenCheck == false)
            {
                return hiddenCheck;
            }
            else
            {
            }
        }
        return hiddenCheck;
    }
}