using System;

public class Entry
{
    public string _currentTime = "";
    public string _journaledText = ""; 
    public string _promptMessage = "";
    
    public void written()
    {
        Console.WriteLine($"\nDate: {_currentTime}");
        Console.WriteLine($"engouragement: {_promptMessage}");
        Console.WriteLine($"Your entry: {_journaledText}");
        Console.WriteLine("------------------------------------------------------");

    }
}