using System;
public static class Kata
{
    // return masked string
    public static string Maskify(string cc)
    {
        char[] chars = cc.ToCharArray();
        for (int i = 0; i < cc.Length - 4; i++)
        {
            chars[i] = '#';
        }
        return new string(chars);
    }
}