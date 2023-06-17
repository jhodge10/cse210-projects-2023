using System;

public class Journal
{
    public List<Entry>_textEntries = new List<Entry>();

    public void Display()
    {
        foreach (Entry entry in _textEntries)
        {
            entry.written();
        }
    }

}