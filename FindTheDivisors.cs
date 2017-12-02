using System.Collections.Generic;
using System;
public class Kata
{
    public static int[] Divisors(int n)
    {
        List<int> divisorsList = new List<int>();

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                if (!divisorsList.Contains(i))
                {
                    divisorsList.Add(i);
                }
                if (!divisorsList.Contains(n / i))
                {
                    divisorsList.Add(n / i);
                }
            }
        }
        divisorsList.Sort();
        var divisorsArray = divisorsList.ToArray();
        return divisorsArray.Length > 0 ? divisorsArray : null;
    }
}