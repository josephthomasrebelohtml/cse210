using System;


public class Comment
{
    private string _text;
    private string _person;

    public Comment(string person, string text)
    {
        _text = text;
        _person = person;
    }

    public string GetDisplayText()
    {
        return $"{_person}:\n{_text}";
    }

}