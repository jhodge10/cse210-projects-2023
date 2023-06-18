using System;

public class Entry
{
    public string _currentTime = "";
    public string _journaledText = ""; 
    public string _promptMessage = "";
    
    public void written()
    {
        Console.WriteLine($"\nDate: {_currentTime}");
        Console.WriteLine($"encouragement: {_promptMessage}");
        Console.WriteLine($"Your entry: {_journaledText}");
        Console.WriteLine("------------------------------------------------------");

    }
}