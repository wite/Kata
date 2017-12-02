using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
    public static int Find(int[] integers)
    {
        List<int> evens = new List<int>();
        List<int> odds = new List<int>();
        foreach (var integer in integers)
        {
            if (integer % 2 == 0)
            {
                evens.Add(integer);
            }
            else
            {
                odds.Add(integer);
            }

            if (evens.Count > odds.Count && odds.Count == 1) return odds.First();
            if (odds.Count > evens.Count && evens.Count == 1) return evens.First();
        }
        return 0;
    }
}