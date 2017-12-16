using System;

public class Kata
{
    public static string Rot13(string message)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string rot13 = "nopqrstuvwxyzabcdefghijklmNOPQRSTUVWXYZABCDEFGHIJKLM";
        List<char> encodedMessage = new List<char>();

        for (int i = 0; i < message.Length; i++)
        {
            int alphabetIndex = alphabet.IndexOf(message[i]);
            if (alphabetIndex >= 0) encodedMessage.Add(rot13[alphabetIndex]);
            else encodedMessage.Add(message[i]);
        }

        return new string(encodedMessage.ToArray());
    }
}