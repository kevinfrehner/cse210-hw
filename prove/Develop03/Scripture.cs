using System;

class Scripture
{
    private Reference reference;
    private Word word;

    public Scripture()
    {
        reference = new Reference();
        word = new Word();
    }


    public void DisplayScripture()
    {
        reference.DisplayReference();
        word.DisplayWords();
    }
    
    public void PopFunction()
    {
        word.PopFunction();
    }
}
