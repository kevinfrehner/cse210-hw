using System;
public class Entry
{
    public string _text;
    public DateTime _date;

    public string _prompt;


    public Entry(string text, DateTime date, string prompt = "")
    {
        this._text = text;
        this._date = date;
        this._prompt = prompt;
    }

    public string GetEntryText()
    {
        return $"{_text}";
    }

    public string GetEntryDate()
    {
        return $"{_date}";
    }

    public string GetFullEntry()
    {
        return $"{_date}: {_text}";
    }

}
