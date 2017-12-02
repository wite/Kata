using System;
using System.Linq;
public static class JadenCase
{
    public static string ToJadenCase(this string phrase)
    {
        bool up = true;
        for (int i = 0; i < phrase.Length; i++)
        {
            if (up)
            {
                phrase = phrase.Insert(i, phrase[i].ToString().ToUpper());
                phrase = phrase.Remove(i + 1, 1);
                up = false;
            }
            if (phrase[i] == ' ')
            {
                up = true;
            }
        }
        return phrase;
    }
}