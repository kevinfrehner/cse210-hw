using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

class Word
{
    private string[] words = "For it must needs be, that there is an opposition in all things. If not so, my firstborn in the wilderness, righteousness could not be brought to pass, neither wickedness, neither holiness nor misery, neither good nor bad. Wherefore, all things must needs be a compound in one; wherefore, if it should be one body it must needs remain as dead, having no life neither death, nor corruption nor incorruption, happiness nor misery, neither sense nor insensibility.".Split(' ');
    private bool[] hidden;

    public Word()
    {
        hidden = new bool[words.Length];
    }

    public void DisplayWords()
    {
        for (int i = 0; i < words.Length; i++)
        {
            Console.Write(hidden[i] ? "____" : words[i]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }

    public void PopFunction()
    {
        Random rand = new Random();
        int attempts = 0;

        while (attempts < 3)
        {
            int index = rand.Next(words.Length);
            if (!hidden[index])
            {
                hidden[index] = true;
                attempts++;
            }
        }
    }
}
