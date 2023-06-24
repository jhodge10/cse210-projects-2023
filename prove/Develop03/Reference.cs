using System;
using System.Collections.Generic;
using System.IO;
public class Reference
{
    private static readonly string Path = "scriptures.txt";
    private Dictionary<List<string>, string> _singleScriptsDico;
    private Dictionary<string[], Dictionary<string[], string[]>> _multiScriptsDico;
    private Dictionary<string[], string[]> verseMultiple = new Dictionary<string[], string[]>();
    public Reference()
    {
        _singleScriptsDico = new Dictionary<List<string>, string>();
        _multiScriptsDico = new Dictionary<string[], Dictionary<string[], string[]>>();

        string[] lines = File.ReadAllLines(Path);

        foreach (string line in lines)
        {
            string[] words = line.Split(' ');
            if (words.Length <= 1)
            {
                continue;
            }

            List<string> referencedScripture = new List<string> { words[0], words[1] };

            List<string> wholeText = new List<string>(words.Skip(2));

            string[] chapterVerses = words[1].Split(":");
            string[] startEndVerse = chapterVerses[1].Contains("-")
                            ? chapterVerses[1].Split("-")
                            : new string[0];
            
            string wholeTextString = string.Join(" ", wholeText);
            string[] splitedVerses = wholeTextString.Contains("^")
                            ? wholeTextString.Split("^")
                            : new string[0];

            if (chapterVerses[1].Contains("-"))
            {
                string[] refMultiple = {words[0], chapterVerses[0]};
                verseMultiple.Add(startEndVerse, splitedVerses);
                _multiScriptsDico.Add(refMultiple, verseMultiple);
            }
            else
            {
                _singleScriptsDico.Add(referencedScripture, wholeTextString);
            }
            
        }
    }

    public Dictionary<List<string>, string> GetSingleScripts()
    {
        return _singleScriptsDico;
    }
    public Dictionary<string[], Dictionary<string[], string[]>> GetMultiScripts()
    {
        return _multiScriptsDico;
    }
}