using System;
using System.Linq;

public class Kata
{
    public static int DuplicateCount(string str)
    {
        string inputString = str.ToLower();
        return inputString.GroupBy(x => x).Where(g => g.Count() > 1).Select(g => g.Key).Count();
    }
}