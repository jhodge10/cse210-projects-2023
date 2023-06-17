using System;

public class Generator
{
    List<string> _encouragement = new List<string>()
    {
        "What did you eat for breakfast today? Did it help your body and/or your mind?",
        "What was the best part of your day today?",
        "What was the strongest emotion you felt today?",
        "If you could have a do over on anything today, what would it be and what would you do differently?",
        "Who was the best/most interesting interaction today?",
        "Did you try anything new today? Whether it be a food and/or activity.",
        "What has someone done for you today?",
        "What have you done for someone today?",
        "Did you try anything out of your comfort/safe zone today? If yes, what was it?",
        "What could you have done better today? Examples: I could have been more kind to my sibling at dinner today. I could ahve done my homework before going and hanging out with my friends."
    };
    
    public string ReturnPrompt(int number)
    {
        return _encouragement[number];
    }
}