using System;
using System.Collections.Generic;


public class Entry
{

    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
    }

    public void Display()
    {
        Console.WriteLine($"{_date}, {_promptText}, {_entryText}");
    }
}
