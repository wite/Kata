using System;
public class Kata
{
    public static bool Narcissistic(int value)
    {
        string valueAsString = value.ToString();
        int power = valueAsString.Length;
        double valueToCompare = 0;

        foreach (var number in valueAsString)
        {
            int nm = (int)Char.GetNumericValue(number);
            valueToCompare = valueToCompare + Math.Pow(nm, power);
        }

        return value == valueToCompare;
    }
}