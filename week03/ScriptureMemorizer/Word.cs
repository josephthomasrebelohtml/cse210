using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        int wordLength = _text.Length;
        _text = "";
        for (int i = 0; i != wordLength; i++)
        {
            _text += "_";
        }
    }

    public bool IsHidden()
    {
        if (_text.Contains("_"))
        {
            _isHidden = true;
        }

        else
        {
            _isHidden = false;
        }
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _text;
    }




}