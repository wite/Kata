using System;
using System.Collections.Generic;

public class SumDigPower
{

    public static long[] SumDigPow(long a, long b)
    {
        List<long> numbersWithProperty = new List<long>();
        for (long x = a; x <= b; x++)
        {
            string valueAsString = x.ToString();
            long power = valueAsString.Length;
            double valueSecond = 0;
            for (int i = 0; i < power; i++)
            {
                valueSecond += Math.Pow(Char.GetNumericValue(valueAsString[i]), i + 1);
            }
            if (x == valueSecond) numbersWithProperty.Add(x);
        }
        return numbersWithProperty.ToArray();
    }
}