//Coordinates word hiding logic by interacting with the Scripture class to hide multiple words.

using System;

class WordHider
{
    private Scripture scripture;

    public WordHider(Scripture scripture)
    {
        this.scripture = scripture;
    }

    public void HideRandomWords()
    {
        for (int i = 0; i < 3; i++)
        {
            scripture.HideRandomWord();
        }
    }
}
