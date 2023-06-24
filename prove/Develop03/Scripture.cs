using System.Linq;
using System;
using System.Text;
public class Scripture
{
    private string _memoVerse = "";

    public Scripture()
    {
        Word wordOfGod = new Word();
        _memoVerse = wordOfGod.Show();
    }
    public string displayWhole()
    {
        Console.WriteLine(_memoVerse);
        return _memoVerse;
    }
    
    public string Hidden(string hidethis)
    {
        Word hiddingWordOfGod = new Word();
        string _hiddenVerse = hiddingWordOfGod.Hide(hidethis);
        return _hiddenVerse;
    }
    public void Erase()
    {
        Console.Clear();
    }
}