using System;

public static class Kata
{
    public static int TrailingZeros(int n)
    {
        int counter;
        int staticMultiplier = 5;
        int multiplier = 5;
        int trailingZeros = counter = n / staticMultiplier;
        while (counter > 1)
        {
            multiplier *= staticMultiplier;
            counter = n / multiplier;
            trailingZeros += counter;
        }
        return trailingZeros;
    }
}