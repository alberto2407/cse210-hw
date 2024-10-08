using System;

class Word
{
    private string text;
    private bool isHidden;

    public Word(string _text)
    {
        text = _text;
        isHidden = false;
    }

    public void Hide()
    {
        isHidden = true;
    }

    public void Show()
    {
        isHidden = false;
    }

    public bool GetIsHidden()
    {
        return isHidden;
    }

    public string GetDisplayText()
    {
        return isHidden ? new string('_', text.Length) : text;
    }
}